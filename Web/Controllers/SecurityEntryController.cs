using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;
using Web.Models.Domain;

namespace Web.Controllers {
    public class SecurityEntryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityEntryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var entries = _context.Entry
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .Include(t => t.Trailer)
                .Include(t => t.Vehicle)
                .Where(e => e.Remittance.Date.Date == DateTime.Today)
                .Where(e => e.EntryDate != e.ExitDate || e.EntryDate == null);

            return View(await entries.ToListAsync());
        }

        // GET SecurityEntry/Detail/4
        public async Task<IActionResult> Detail(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var info = _context.Entry
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .ThenInclude(r => r.Client)
                .Include(t => t.Trailer)
                .ThenInclude(t => t.Insurance)
                .Include(t => t.Vehicle)
                .ThenInclude(v => v.Insurance)
                .First(e => e.Id == id);
            var permit = _context.DriverPermit
                .Where(x => x.DriverId == info.DriverId)
                .Where(x => x.VehicleId == info.VehicleId)
                .OrderByDescending(x => x.ExpirationDate)
                .First();

            if (info == null)
            {
                return NotFound();
            }

            return View(new SecurityViewModel {Entry = info, DriverPermit = permit, ExitConfirmation = 0, CanEnter = true});
        }

        public bool CanEnter(Entry entry, DriverPermit permit)
        {
            return true;
        }
        // POST: SecurityEntry/Authorize/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authorize(long? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }

            var entry = _context.Entry.Include(d => d.Remittance).First(e => e.Id == Id);
            ;

            entry.EntryDate = DateTime.Now;

            var os = new OperationState {RemittanceId = entry.Remittance.Id, EntryId = entry.Id};

            try
            {
                _context.OperationState.Add(os);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Reject")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RejectConfirmed(long Id, string RejectionText)
        {

            var entry = _context.Entry.Find(Id);
            var date = DateTime.Now;

            entry.EntryDate = date;
            entry.ExitDate = date;
            entry.RejectionReason = RejectionText;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));

        }

        [HttpPost, ActionName("Exit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExitConfirmed(long Id)
        {
            var operationState = _context.OperationState.First(os => os.EntryId == Id);

            var info = _context.Entry
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .ThenInclude(r => r.Client)
                .Include(t => t.Trailer)
                .ThenInclude(t => t.Insurance)
                .Include(t => t.Vehicle)
                .ThenInclude(v => v.Insurance)
                .First(e => e.Id == Id);
            var permit = _context.DriverPermit
                .Where(x => x.DriverId == info.DriverId)
                .Where(x => x.VehicleId == info.VehicleId)
                .OrderByDescending(x => x.ExpirationDate)
                .First();


            if (operationState.MerchandiseState == "Downloaded" || operationState.RemittanceState ==
                OperationState.PossibleRemittanceStates.Rejected.ToString())
            {
                var entry = _context.Entry.Find(Id);

                entry.ExitDate = DateTime.Now;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("ExitConfirmation", "Error: El vehículo esta descargando mercadería");
                return View("~/Views/SecurityEntry/Detail.cshtml",
                    new SecurityViewModel {Entry = info, DriverPermit = permit, ExitConfirmation = 0});
            }

        }
    }
}