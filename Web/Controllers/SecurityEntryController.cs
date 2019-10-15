using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Controllers
{
    public class SecurityEntryController: Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityEntryController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var entries = _context.Entry
                .Where(e => e.EntryDate.Date == DateTime.Today)
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .Include(t => t.Trailer)
                .Include(t => t.Vehicle);
           
            return View(await entries.ToListAsync());
        }

        // GET SecurityEntry/Detail/4
        public async Task<IActionResult> Detail(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var info = _context.Entry
                .Where(e => e.EntryDate.Date == DateTime.Today)
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .Include(t => t.Trailer)
                .Include(t => t.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);;

            return View(await info);
        }
        
        // POST: SecurityEntry/Authorize/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authorize(long entryId)
        {
            return NotFound();
        }
    }
}