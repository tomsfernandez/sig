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
    public class TrailerInsuranceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrailerInsuranceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TrailerInsurance
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrailerInsurance.ToListAsync());
        }

        // GET: TrailerInsurance/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailerInsurance = await _context.TrailerInsurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trailerInsurance == null)
            {
                return NotFound();
            }

            return View(trailerInsurance);
        }

        // GET: TrailerInsurance/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrailerInsurance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PolicyNumber,ExpirationDate,InsuranceBusinessName")] TrailerInsurance trailerInsurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trailerInsurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trailerInsurance);
        }

        // GET: TrailerInsurance/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailerInsurance = await _context.TrailerInsurance.FindAsync(id);
            if (trailerInsurance == null)
            {
                return NotFound();
            }
            return View(trailerInsurance);
        }

        // POST: TrailerInsurance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,PolicyNumber,ExpirationDate,InsuranceBusinessName")] TrailerInsurance trailerInsurance)
        {
            if (id != trailerInsurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trailerInsurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrailerInsuranceExists(trailerInsurance.Id))
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
            return View(trailerInsurance);
        }

        // GET: TrailerInsurance/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailerInsurance = await _context.TrailerInsurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trailerInsurance == null)
            {
                return NotFound();
            }

            return View(trailerInsurance);
        }

        // POST: TrailerInsurance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var trailerInsurance = await _context.TrailerInsurance.FindAsync(id);
            _context.TrailerInsurance.Remove(trailerInsurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrailerInsuranceExists(long id)
        {
            return _context.TrailerInsurance.Any(e => e.Id == id);
        }
    }
}
