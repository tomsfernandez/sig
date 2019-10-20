using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web.Controllers {
    public class DownloadWorkflowController : Controller{

        private readonly ApplicationDbContext _context;

        public DownloadWorkflowController(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> ListEnteredRemittances() {
            var entries = await new TodayEntriesQuery(_context).Query();
            var remittanceIds = entries.Where(x => x.HasEntered()).Select(x => x.Remittance).Select(r => r.Id);
            var remittances = await _context.Remittance.Where(x => remittanceIds.Contains(x.Id))
                .Include(x => x.Client)
                .Include(x => x.OperationState)
                .ThenInclude(x => x.Dock)
                .ToListAsync();
            var result = remittances.Select(x => new RemittanceToDownload {
                ClientName = x.Client.BusinessName,
                State = x.OperationState.State(),
                DeliveryType = x.DeliveryType
            });
            return View(result);
        }
    }
}