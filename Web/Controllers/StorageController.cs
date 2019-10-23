using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Controllers {
    public class StorageController : Controller {
        public ApplicationDbContext Context { get; set; }

        public StorageController(ApplicationDbContext context) {
            Context = context;
        }

        public async Task<IActionResult> PalletsForDownload() {
            var palletsToDownload = await Context.Pallet
                .Include(x => x.Merchandise)
                .Where(x => x.EntryTimestamp != DateTime.MinValue)
                .Where(x => x.ExitTimestamp == DateTime.MinValue)
                .Where(x => x.State == "Downloaded")
                .ToListAsync();
            return View(palletsToDownload);
        }

        public async Task<IActionResult> StorageConfirmation(long Id) {
            var occupiedWarehouses = await Context.Pallet
                .Where(x => x.State == "Stored")
                .Select(x => x.WarehouseLocationId)
                .ToListAsync();
            var availableWarehouses = await Context.WarehouseLocation
                .Where(x => !occupiedWarehouses.Contains(x.Id))
                .ToListAsync();
            return View(new ToStoreViewModel {
                PalletId = Id,
                WarehouseLocation = availableWarehouses.First(),
                ConfirmedLocationId = 0
            });
        }

        [HttpPost]
        public async Task<IActionResult> StorageConfirmation(long PalletId, long LocationId, long ConfirmedLocationId) {
            if (LocationId == ConfirmedLocationId) {
                var pallet = await Context.Pallet.FindAsync(PalletId);
                pallet.State = "Stored";
                pallet.WarehouseLocationId = LocationId;
                await Context.SaveChangesAsync();
                return RedirectToAction(nameof(PalletsForDownload));
            }
            ModelState.AddModelError("ConfirmedLocationId", "Los códigos de ubicación no concuerdan");
            var warehouse = await Context.WarehouseLocation.FindAsync(LocationId);
            return View(new ToStoreViewModel {
                PalletId = PalletId,
                WarehouseLocation = warehouse,
                ConfirmedLocationId = 0
            });
        }
    }
}