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
    public class OperationStateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OperationStateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OperationState
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OperationState.Include(o => o.Dock).Include(o => o.Entry).Include(o => o.Remittance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OperationState/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationState = await _context.OperationState
                .Include(o => o.Dock)
                .Include(o => o.Entry)
                .Include(o => o.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationState == null)
            {
                return NotFound();
            }

            return View(operationState);
        }

        // GET: OperationState/Create
        public IActionResult Create()
        {
            ViewData["DockId"] = new SelectList(_context.Dock, "Id", "Id");
            ViewData["EntryId"] = new SelectList(_context.Entry, "Id", "Id");
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id");
            return View();
        }

        // POST: OperationState/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RemittanceState,MerchandiseState,RemittanceId,EntryId,DockId")] OperationState operationState)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operationState);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DockId"] = new SelectList(_context.Dock, "Id", "Id", operationState.DockId);
            ViewData["EntryId"] = new SelectList(_context.Entry, "Id", "Id", operationState.EntryId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", operationState.RemittanceId);
            return View(operationState);
        }

        // GET: OperationState/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationState = await _context.OperationState.FindAsync(id);
            if (operationState == null)
            {
                return NotFound();
            }
            ViewData["DockId"] = new SelectList(_context.Dock, "Id", "Id", operationState.DockId);
            ViewData["EntryId"] = new SelectList(_context.Entry, "Id", "Id", operationState.EntryId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", operationState.RemittanceId);
            return View(operationState);
        }

        // POST: OperationState/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,RemittanceState,MerchandiseState,RemittanceId,EntryId,DockId")] OperationState operationState)
        {
            if (id != operationState.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationState);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationStateExists(operationState.Id))
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
            ViewData["DockId"] = new SelectList(_context.Dock, "Id", "Id", operationState.DockId);
            ViewData["EntryId"] = new SelectList(_context.Entry, "Id", "Id", operationState.EntryId);
            ViewData["RemittanceId"] = new SelectList(_context.Remittance, "Id", "Id", operationState.RemittanceId);
            return View(operationState);
        }

        // GET: OperationState/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationState = await _context.OperationState
                .Include(o => o.Dock)
                .Include(o => o.Entry)
                .Include(o => o.Remittance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationState == null)
            {
                return NotFound();
            }

            return View(operationState);
        }

        // POST: OperationState/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var operationState = await _context.OperationState.FindAsync(id);
            _context.OperationState.Remove(operationState);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperationStateExists(long id)
        {
            return _context.OperationState.Any(e => e.Id == id);
        }
    }
}
