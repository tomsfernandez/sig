using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Models.Domain;

namespace Web.Controllers {
    public class DownloadWorkflowController : Controller{

        private readonly ApplicationDbContext _context;

        public DownloadWorkflowController(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> ListEnteredRemittances() {
            var entries = await new TodayEntriesQuery(_context).Query();
            var remittanceIds = entries.Where(x => x.HasEntered()).Select(x => x.Remittance).Select(r => r.Id);
            var remittances = await _context.Remittance.Where(x => remittanceIds.Contains(x.Id))
                .Include(x => x.Client)
                .Include(x => x.OperationState)
                    .ThenInclude(x => x.Dock)
                .Where(x => x.OperationState.RemittanceState == "")
                .ToListAsync();
            var result = remittances.Select(x => new RemittanceToDownload {
                ClientName = x.Client.BusinessName,
                State = x.OperationState.State(),
                DeliveryType = x.DeliveryType,
                Dock = x.OperationState.Dock == null ? "Sin Asignar" : x.OperationState.Dock.Id.ToString(),
                Id = x.Id,
                InDownload = x.OperationState.MerchandiseState != ""
            });
            return View(result);
        }

        public async Task<IActionResult> MerchControl(long Id) {
            var remittance = await _context.Remittance
                .Include(x => x.Merchandise)
                .Include(x => x.OperationState)
                .SingleAsync(x => x.Id == Id);
            return View(new MerchandiseControlViewModel {
                RemittanceId = remittance.Id,
                Merchandises = remittance.Merchandise,
                OperationStateId = remittance.OperationState.Id
            });
        }

        public async Task<IActionResult> RejectRemittance(long Id) {
            var operationState = await _context.OperationState.FindAsync(Id);
            operationState.RemittanceState = OperationState.PossibleRemittanceStates.Rejected.ToString();
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListEnteredRemittances));
        }

        public async Task<IActionResult> ChooseDownloadDock(long Id) {
            var operation = await _context.OperationState.FindAsync(Id);
            operation.MerchandiseState = "InDownload";
            if (operation.DockId != null) {
                return RedirectToAction(nameof(StartDownload), new {OperationId = Id, DockId = operation.DockId});
            }
            var docks = await _context.Dock.ToListAsync();
            await _context.SaveChangesAsync();
            return View(new ChooseDocksViewModel {
                OperationId = Id,
                Docks = docks
            });
        }

        public async Task<IActionResult> StartDownload(long OperationId, long DockId) {
            var dock = await _context.Dock.FindAsync(DockId);
            dock.Occupied = 0;
            var operation = await _context.OperationState
                .Include(x => x.Dock)
                .Include(x => x.Remittance)
                    .ThenInclude(x => x.Merchandise)
                .SingleAsync(x => x.Id == OperationId);
            operation.Dock = dock;
            await _context.SaveChangesAsync();
            return View(operation);
        }

        public async Task<IActionResult> SubmitDownload() {
            var merchandiseIds = Request.Form.Keys
                .Where(x => x != "OperationId" && x != "__RequestVerificationToken")
                .Select(x => long.Parse(x))
                .ToList();
            var operationId = long.Parse(Request.Form["OperationId"]);
            var operation = await _context.OperationState
                .Include(x => x.Dock)
                .SingleAsync(x => x.Id == operationId);
            var merchandises = await _context.Merchandise.Where(x => merchandiseIds.Contains(x.Id)).ToListAsync();
            merchandises.ForEach(m => m.DownloadedPallets = int.Parse(Request.Form[m.Id.ToString()]));
            var acceptFull = merchandises.Select(m => m.DownloadedPallets == m.RequestedPallets)
                .Aggregate(true, (acc, curr) => acc && curr);
            if (acceptFull) operation.RemittanceState = OperationState.PossibleRemittanceStates.Accepted.ToString();
            else operation.RemittanceState = OperationState.PossibleRemittanceStates.PartiallyAccepted.ToString();
            operation.MerchandiseState = "Downloaded";
            operation.Dock.Occupied = false;
            var pallets = merchandises.SelectMany(x => {
                return Enumerable.Range(0, x.DownloadedPallets).Select(y => new Pallet {
                    EntryTimestamp = DateTime.Now,
                    AmountOfBoxes = 100000,
                    Height = 100,
                    Weight = 3,
                    MerchandiseId = x.Id
                });
            }).ToList();
            _context.Pallet.AddRange(pallets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListEnteredRemittances));
        }
    }
}