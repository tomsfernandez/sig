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
    public class MerchandiseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MerchandiseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Merchandise
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Merchandise.Include(m => m.Remittance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Merchandise/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise
                .Include(m => m.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandise == null)
            {
                return NotFound();
            }

            return View(merchandise);
        }

        // GET: Merchandise/Create
        public IActionResult Create()
        {
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id");
            return View();
        }

        // POST: Merchandise/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,ExternCode,TotalBoxes,BoxHeight,BoxWidth,BoxLength,BoxWeight,RemittanceId")] Merchandise merchandise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchandise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandise.RemittanceId);
            return View(merchandise);
        }

        // GET: Merchandise/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise.FindAsync(id);
            if (merchandise == null)
            {
                return NotFound();
            }
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandise.RemittanceId);
            return View(merchandise);
        }

        // POST: Merchandise/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Description,ExternCode,TotalBoxes,BoxHeight,BoxWidth,BoxLength,BoxWeight,RemittanceId")] Merchandise merchandise)
        {
            if (id != merchandise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchandise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchandiseExists(merchandise.Id))
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
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", merchandise.RemittanceId);
            return View(merchandise);
        }

        // GET: Merchandise/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise
                .Include(m => m.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandise == null)
            {
                return NotFound();
            }

            return View(merchandise);
        }

        // POST: Merchandise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var merchandise = await _context.Merchandise.FindAsync(id);
            _context.Merchandise.Remove(merchandise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchandiseExists(long id)
        {
            return _context.Merchandise.Any(e => e.Id == id);
        }
    }
}
