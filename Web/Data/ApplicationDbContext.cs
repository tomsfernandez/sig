using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Models.Domain;

namespace Web.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Web.Models.Domain.Driver> Driver { get; set; }
        public DbSet<Web.Models.Domain.Address> Address { get; set; }
        public DbSet<Web.Models.Domain.Client> Client { get; set; }
        public DbSet<Web.Models.Domain.Dock> Dock { get; set; }
        public DbSet<Web.Models.Domain.RTO> RTO { get; set; }
        public DbSet<Web.Models.Domain.RUTA> RUTA { get; set; }
        public DbSet<Web.Models.Domain.TrailerInsurance> TrailerInsurance { get; set; }
        public DbSet<Web.Models.Domain.VehicleInsurance> VehicleInsurance { get; set; }
        public DbSet<Web.Models.Domain.WarehouseLocation> WarehouseLocation { get; set; }
        public DbSet<Web.Models.Domain.Vehicle> Vehicle { get; set; }
        public DbSet<Web.Models.Domain.Trailer> Trailer { get; set; }
        public DbSet<Web.Models.Domain.DriverPermit> DriverPermit { get; set; }
        public DbSet<Web.Models.Domain.Remittance> Remittance { get; set; }
        
    }
}