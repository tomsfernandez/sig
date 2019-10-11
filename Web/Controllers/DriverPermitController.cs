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
    public class DriverPermitController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriverPermitController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DriverPermit
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DriverPermit.Include(d => d.Driver).Include(d => d.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DriverPermit/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driverPermit = await _context.DriverPermit
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driverPermit == null)
            {
                return NotFound();
            }

            return View(driverPermit);
        }

        // GET: DriverPermit/Create
        public IActionResult Create()
        {
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id");
            return View();
        }

        // POST: DriverPermit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,DriverId,ExpirationDate")] DriverPermit driverPermit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driverPermit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", driverPermit.DriverId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", driverPermit.VehicleId);
            return View(driverPermit);
        }

        // GET: DriverPermit/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driverPermit = await _context.DriverPermit.FindAsync(id);
            if (driverPermit == null)
            {
                return NotFound();
            }
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", driverPermit.DriverId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", driverPermit.VehicleId);
            return View(driverPermit);
        }

        // POST: DriverPermit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,VehicleId,DriverId,ExpirationDate")] DriverPermit driverPermit)
        {
            if (id != driverPermit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(driverPermit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriverPermitExists(driverPermit.Id))
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
            ViewData["DriverId"] = new SelectList(_context.Driver, "Id", "Id", driverPermit.DriverId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Id", driverPermit.VehicleId);
            return View(driverPermit);
        }

        // GET: DriverPermit/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driverPermit = await _context.DriverPermit
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driverPermit == null)
            {
                return NotFound();
            }

            return View(driverPermit);
        }

        // POST: DriverPermit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var driverPermit = await _context.DriverPermit.FindAsync(id);
            _context.DriverPermit.Remove(driverPermit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DriverPermitExists(long id)
        {
            return _context.DriverPermit.Any(e => e.Id == id);
        }
    }
}
