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
    public class MerchandiseInsuranceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MerchandiseInsuranceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MerchandiseInsurance
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MerchandiseInsurance.Include(m => m.Remittance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MerchandiseInsurance/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandiseInsurance = await _context.MerchandiseInsurance
                .Include(m => m.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandiseInsurance == null)
            {
                return NotFound();
            }

            return View(merchandiseInsurance);
        }

        // GET: MerchandiseInsurance/Create
        public IActionResult Create()
        {
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id");
            return View();
        }

        // POST: MerchandiseInsurance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PolicyNumber,CoverageType,SafetyMeasures,InsuredMerchandise,ExpirationDate,InsuranceBusinessName,RemittanceId")] MerchandiseInsurance merchandiseInsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchandiseInsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandiseInsurance.RemittanceId);
            return View(merchandiseInsurance);
        }

        // GET: MerchandiseInsurance/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandiseInsurance = await _context.MerchandiseInsurance.FindAsync(id);
            if (merchandiseInsurance == null)
            {
                return NotFound();
            }
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandiseInsurance.RemittanceId);
            return View(merchandiseInsurance);
        }

        // POST: MerchandiseInsurance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,PolicyNumber,CoverageType,SafetyMeasures,InsuredMerchandise,ExpirationDate,InsuranceBusinessName,RemittanceId")] MerchandiseInsurance merchandiseInsurance)
        {
            if (id != merchandiseInsurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchandiseInsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchandiseInsuranceExists(merchandiseInsurance.Id))
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
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandiseInsurance.RemittanceId);
            return View(merchandiseInsurance);
        }

        // GET: MerchandiseInsurance/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandiseInsurance = await _context.MerchandiseInsurance
                .Include(m => m.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandiseInsurance == null)
            {
                return NotFound();
            }

            return View(merchandiseInsurance);
        }

        // POST: MerchandiseInsurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var merchandiseInsurance = await _context.MerchandiseInsurance.FindAsync(id);
            _context.MerchandiseInsurance.Remove(merchandiseInsurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchandiseInsuranceExists(long id)
        {
            return _context.MerchandiseInsurance.Any(e => e.Id == id);
        }
    }
}
