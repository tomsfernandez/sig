using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Models.Domain;

namespace Web.Data {
    public class TodayEntriesQuery {
        
        public ApplicationDbContext Context { get; }

        public TodayEntriesQuery(ApplicationDbContext context) {
            Context = context;
        }

        public async Task<List<Entry>> Query() {
            return await Query(DateTime.Today);
        }

        public async Task<List<Entry>> Query(DateTime date) {
            var entries = Context.Entry
                .Include(t => t.Driver)
                .Include(t => t.Remittance)
                .Include(t => t.Trailer)
                .Include(t => t.Vehicle)
                .Where(e => e.Remittance.Date.Date == DateTime.Today);
            return await entries.ToListAsync();
        }
    }
}