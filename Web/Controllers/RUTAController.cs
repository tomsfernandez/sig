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
    public class RUTAController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RUTAController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RUTA
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RUTA.Include(r => r.Client).Include(r => r.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RUTA/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rUTA = await _context.RUTA
                .Include(r => r.Client)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rUTA == null)
            {
                return NotFound();
            }

            return View(rUTA);
        }

        // GET: RUTA/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id");
            return View();
        }

        // POST: RUTA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,ClientId,CreationDate,Category")] RUTA rUTA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rUTA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rUTA.ClientId);
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rUTA.VehicleId);
            return View(rUTA);
        }

        // GET: RUTA/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rUTA = await _context.RUTA.FindAsync(id);
            if (rUTA == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rUTA.ClientId);
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rUTA.VehicleId);
            return View(rUTA);
        }

        // POST: RUTA/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,VehicleId,ClientId,CreationDate,Category")] RUTA rUTA)
        {
            if (id != rUTA.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rUTA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RUTAExists(rUTA.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rUTA.ClientId);
            ViewData["VehicleId"] = new SelectList(_context.Set<Vehicle>(), "Id", "Id", rUTA.VehicleId);
            return View(rUTA);
        }

        // GET: RUTA/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rUTA = await _context.RUTA
                .Include(r => r.Client)
                .Include(r => r.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rUTA == null)
            {
                return NotFound();
            }

            return View(rUTA);
        }

        // POST: RUTA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var rUTA = await _context.RUTA.FindAsync(id);
            _context.RUTA.Remove(rUTA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RUTAExists(long id)
        {
            return _context.RUTA.Any(e => e.Id == id);
        }
    }
}
