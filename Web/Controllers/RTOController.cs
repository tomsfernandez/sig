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
    public class RTOController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RTOController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RTO
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RTO.Include(r => r.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RTO/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rTO = await _context.RTO
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rTO == null)
            {
                return NotFound();
            }

            return View(rTO);
        }

        // GET: RTO/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id");
            return View();
        }

        // POST: RTO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,ExpirationDate,CertifiedBy")] RTO rTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rTO.VehicleId);
            return View(rTO);
        }

        // GET: RTO/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rTO = await _context.RTO.FindAsync(id);
            if (rTO == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rTO.VehicleId);
            return View(rTO);
        }

        // POST: RTO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,VehicleId,ExpirationDate,CertifiedBy")] RTO rTO)
        {
            if (id != rTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RTOExists(rTO.Id))
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
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rTO.VehicleId);
            return View(rTO);
        }

        // GET: RTO/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rTO = await _context.RTO
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rTO == null)
            {
                return NotFound();
            }

            return View(rTO);
        }

        // POST: RTO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var rTO = await _context.RTO.FindAsync(id);
            _context.RTO.Remove(rTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RTOExists(long id)
        {
            return _context.RTO.Any(e => e.Id == id);
        }
    }
}
