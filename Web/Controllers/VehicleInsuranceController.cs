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
    public class VehicleInsuranceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehicleInsuranceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VehicleInsurance
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehicleInsurance.ToListAsync());
        }

        // GET: VehicleInsurance/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInsurance = await _context.VehicleInsurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleInsurance == null)
            {
                return NotFound();
            }

            return View(vehicleInsurance);
        }

        // GET: VehicleInsurance/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleInsurance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PolicyNumber,ExpirationDate,InsuranceBusinessName")] VehicleInsurance vehicleInsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleInsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleInsurance);
        }

        // GET: VehicleInsurance/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInsurance = await _context.VehicleInsurance.FindAsync(id);
            if (vehicleInsurance == null)
            {
                return NotFound();
            }
            return View(vehicleInsurance);
        }

        // POST: VehicleInsurance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,PolicyNumber,ExpirationDate,InsuranceBusinessName")] VehicleInsurance vehicleInsurance)
        {
            if (id != vehicleInsurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleInsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleInsuranceExists(vehicleInsurance.Id))
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
            return View(vehicleInsurance);
        }

        // GET: VehicleInsurance/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInsurance = await _context.VehicleInsurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleInsurance == null)
            {
                return NotFound();
            }

            return View(vehicleInsurance);
        }

        // POST: VehicleInsurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var vehicleInsurance = await _context.VehicleInsurance.FindAsync(id);
            _context.VehicleInsurance.Remove(vehicleInsurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleInsuranceExists(long id)
        {
            return _context.VehicleInsurance.Any(e => e.Id == id);
        }
    }
}
