using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models.Domain;

namespace Web.Controllers
{
    public class PalletController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PalletController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pallet
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pallet.Include(p => p.Merchandise).Include(p => p.WarehouseLocation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pallet/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pallet = await _context.Pallet
                .Include(p => p.Merchandise)
                .Include(p => p.WarehouseLocation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pallet == null)
            {
                return NotFound();
            }

            return View(pallet);
        }

        // GET: Pallet/Create
        public IActionResult Create()
        {
            ViewData["MerchandiseId"] = new SelectList(_context.Merchandise, "Id", "Id");
            ViewData["WarehouseLocationId"] = new SelectList(_context.WarehouseLocation, "Id", "Id");
            return View();
        }

        // POST: Pallet/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AmountOfBoxes,Weight,Height,EntryTimestamp,ExitTimestamp,State,WarehouseLocationId,MerchandiseId")] Pallet pallet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pallet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MerchandiseId"] = new SelectList(_context.Merchandise, "Id", "Id", pallet.MerchandiseId);
            ViewData["WarehouseLocationId"] = new SelectList(_context.WarehouseLocation, "Id", "Id", pallet.WarehouseLocationId);
            return View(pallet);
        }

        // GET: Pallet/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pallet = await _context.Pallet.FindAsync(id);
            if (pallet == null)
            {
                return NotFound();
            }
            ViewData["MerchandiseId"] = new SelectList(_context.Merchandise, "Id", "Id", pallet.MerchandiseId);
            ViewData["WarehouseLocationId"] = new SelectList(_context.WarehouseLocation, "Id", "Id", pallet.WarehouseLocationId);
            return View(pallet);
        }

        // POST: Pallet/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,AmountOfBoxes,Weight,Height,EntryTimestamp,ExitTimestamp,State,WarehouseLocationId,MerchandiseId")] Pallet pallet)
        {
            if (id != pallet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pallet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PalletExists(pallet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MerchandiseId"] = new SelectList(_context.Merchandise, "Id", "Id", pallet.MerchandiseId);
            ViewData["WarehouseLocationId"] = new SelectList(_context.WarehouseLocation, "Id", "Id", pallet.WarehouseLocationId);
            return View(pallet);
        }

        // GET: Pallet/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pallet = await _context.Pallet
                .Include(p => p.Merchandise)
                .Include(p => p.WarehouseLocation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pallet == null)
            {
                return NotFound();
            }

            return View(pallet);
        }

        // POST: Pallet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pallet = await _context.Pallet.FindAsync(id);
            _context.Pallet.Remove(pallet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PalletExists(long id)
        {
            return _context.Pallet.Any(e => e.Id == id);
        }
    }
}
