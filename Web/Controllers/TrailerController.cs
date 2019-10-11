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
    public class TrailerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrailerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trailer
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Trailer.Include(t => t.Insurance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Trailer/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailer = await _context.Trailer
                .Include(t => t.Insurance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trailer == null)
            {
                return NotFound();
            }

            return View(trailer);
        }

        // GET: Trailer/Create
        public IActionResult Create()
        {
            ViewData["TrailerInsuranceId"] = new SelectList(_context.TrailerInsurance, "Id", "Id");
            return View();
        }

        // POST: Trailer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LicensePlate,TrailerInsuranceId")] Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trailer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrailerInsuranceId"] = new SelectList(_context.TrailerInsurance, "Id", "Id", trailer.TrailerInsuranceId);
            return View(trailer);
        }

        // GET: Trailer/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailer = await _context.Trailer.FindAsync(id);
            if (trailer == null)
            {
                return NotFound();
            }
            ViewData["TrailerInsuranceId"] = new SelectList(_context.TrailerInsurance, "Id", "Id", trailer.TrailerInsuranceId);
            return View(trailer);
        }

        // POST: Trailer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,LicensePlate,TrailerInsuranceId")] Trailer trailer)
        {
            if (id != trailer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trailer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrailerExists(trailer.Id))
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
            ViewData["TrailerInsuranceId"] = new SelectList(_context.TrailerInsurance, "Id", "Id", trailer.TrailerInsuranceId);
            return View(trailer);
        }

        // GET: Trailer/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailer = await _context.Trailer
                .Include(t => t.Insurance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trailer == null)
            {
                return NotFound();
            }

            return View(trailer);
        }

        // POST: Trailer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var trailer = await _context.Trailer.FindAsync(id);
            _context.Trailer.Remove(trailer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrailerExists(long id)
        {
            return _context.Trailer.Any(e => e.Id == id);
        }
    }
}
