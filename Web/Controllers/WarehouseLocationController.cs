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
    public class WarehouseLocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarehouseLocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarehouseLocation
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarehouseLocation.ToListAsync());
        }

        // GET: WarehouseLocation/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseLocation = await _context.WarehouseLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warehouseLocation == null)
            {
                return NotFound();
            }

            return View(warehouseLocation);
        }

        // GET: WarehouseLocation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarehouseLocation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Section,Aisle,Position,Level")] WarehouseLocation warehouseLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warehouseLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseLocation);
        }

        // GET: WarehouseLocation/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseLocation = await _context.WarehouseLocation.FindAsync(id);
            if (warehouseLocation == null)
            {
                return NotFound();
            }
            return View(warehouseLocation);
        }

        // POST: WarehouseLocation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Section,Aisle,Position,Level")] WarehouseLocation warehouseLocation)
        {
            if (id != warehouseLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warehouseLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarehouseLocationExists(warehouseLocation.Id))
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
            return View(warehouseLocation);
        }

        // GET: WarehouseLocation/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouseLocation = await _context.WarehouseLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warehouseLocation == null)
            {
                return NotFound();
            }

            return View(warehouseLocation);
        }

        // POST: WarehouseLocation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var warehouseLocation = await _context.WarehouseLocation.FindAsync(id);
            _context.WarehouseLocation.Remove(warehouseLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarehouseLocationExists(long id)
        {
            return _context.WarehouseLocation.Any(e => e.Id == id);
        }
    }
}
