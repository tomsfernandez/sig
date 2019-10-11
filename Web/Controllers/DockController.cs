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
    public class DockController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DockController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dock
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dock.ToListAsync());
        }

        // GET: Dock/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dock = await _context.Dock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dock == null)
            {
                return NotFound();
            }

            return View(dock);
        }

        // GET: Dock/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dock/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Occupied")] Dock dock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dock);
        }

        // GET: Dock/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dock = await _context.Dock.FindAsync(id);
            if (dock == null)
            {
                return NotFound();
            }
            return View(dock);
        }

        // POST: Dock/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Occupied")] Dock dock)
        {
            if (id != dock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DockExists(dock.Id))
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
            return View(dock);
        }

        // GET: Dock/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dock = await _context.Dock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dock == null)
            {
                return NotFound();
            }

            return View(dock);
        }

        // POST: Dock/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var dock = await _context.Dock.FindAsync(id);
            _context.Dock.Remove(dock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DockExists(long id)
        {
            return _context.Dock.Any(e => e.Id == id);
        }
    }
}
