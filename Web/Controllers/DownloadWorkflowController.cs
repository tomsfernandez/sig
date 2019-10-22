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
                .Where(x => x.OperationState.RemittanceState != OperationState.PossibleRemittanceStates.Rejected.ToString())
                .ToListAsync();
            var result = remittances.Select(x => new RemittanceToDownload {
                ClientName = x.Client.BusinessName,
                State = x.OperationState.State(),
                DeliveryType = x.DeliveryType,
                Dock = x.OperationState.Dock == null ? "Sin Asignar" : x.OperationState.Dock.Id.ToString(),
                Id = x.Id
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
            var docks = await _context.Dock.ToListAsync();
            return View(new ChooseDocksViewModel {
                OperationId = Id,
                Docks = docks
            });
        }

        public async Task<IActionResult> StartDownload(long OperationId, long DockId) {
            var dock = await _context.Dock.FindAsync(DockId);
            var operation = await _context.OperationState
                .Include(x => x.Remittance)
                    .ThenInclude(x => x.Merchandise)
                .SingleAsync(x => x.Id == OperationId);
            operation.Dock = dock;
            await _context.SaveChangesAsync();
            return View(operation.Remittance.Merchandise);
        }
    }
}