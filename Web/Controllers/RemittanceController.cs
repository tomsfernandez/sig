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
    public class RemittanceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RemittanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Remittance
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Remittance.Include(r => r.Client);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Remittance/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remittance = await _context.Remittance
                .Include(r => r.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (remittance == null)
            {
                return NotFound();
            }

            return View(remittance);
        }

        // GET: Remittance/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id");
            return View();
        }

        // POST: Remittance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,DeliveryType,ClientId")] Remittance remittance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(remittance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", remittance.ClientId);
            return View(remittance);
        }

        // GET: Remittance/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remittance = await _context.Remittance.FindAsync(id);
            if (remittance == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", remittance.ClientId);
            return View(remittance);
        }

        // POST: Remittance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Date,DeliveryType,ClientId")] Remittance remittance)
        {
            if (id != remittance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(remittance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RemittanceExists(remittance.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", remittance.ClientId);
            return View(remittance);
        }

        // GET: Remittance/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remittance = await _context.Remittance
                .Include(r => r.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (remittance == null)
            {
                return NotFound();
            }

            return View(remittance);
        }

        // POST: Remittance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var remittance = await _context.Remittance.FindAsync(id);
            _context.Remittance.Remove(remittance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RemittanceExists(long id)
        {
            return _context.Remittance.Any(e => e.Id == id);
        }
    }
}
