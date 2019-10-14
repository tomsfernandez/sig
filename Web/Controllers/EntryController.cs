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
    public class EntryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Entry
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Entry.Include(e => e.Driver).Include(e => e.Remittance).Include(e => e.Trailer).Include(e => e.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Entry/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entry
                .Include(e => e.Driver)
                .Include(e => e.Remittance)
                .Include(e => e.Trailer)
                .Include(e => e.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // GET: Entry/Create
        public IActionResult Create()
        {
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id");
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id");
            ViewData["TrailerId"] = new SelectList(_context.Trailer, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id");
            return View();
        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EntryDate,ExitDate,RemittanceId,DriverId,VehicleId,TrailerId")] Entry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", entry.DriverId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", entry.RemittanceId);
            ViewData["TrailerId"] = new SelectList(_context.Trailer, "Id", "Id", entry.TrailerId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", entry.VehicleId);
            return View(entry);
        }

        // GET: Entry/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entry.FindAsync(id);
            if (entry == null)
            {
                return NotFound();
            }
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", entry.DriverId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", entry.RemittanceId);
            ViewData["TrailerId"] = new SelectList(_context.Trailer, "Id", "Id", entry.TrailerId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", entry.VehicleId);
            return View(entry);
        }

        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,EntryDate,ExitDate,RemittanceId,DriverId,VehicleId,TrailerId")] Entry entry)
        {
            if (id != entry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntryExists(entry.Id))
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
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", entry.DriverId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", entry.RemittanceId);
            ViewData["TrailerId"] = new SelectList(_context.Trailer, "Id", "Id", entry.TrailerId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", entry.VehicleId);
            return View(entry);
        }

        // GET: Entry/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.Entry
                .Include(e => e.Driver)
                .Include(e => e.Remittance)
                .Include(e => e.Trailer)
                .Include(e => e.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // POST: Entry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var entry = await _context.Entry.FindAsync(id);
            _context.Entry.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntryExists(long id)
        {
            return _context.Entry.Any(e => e.Id == id);
        }
    }
}
