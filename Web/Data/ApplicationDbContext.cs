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
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Dock> Dock { get; set; }
        public DbSet<RTO> RTO { get; set; }
        public DbSet<RUTA> RUTA { get; set; }
        public DbSet<TrailerInsurance> TrailerInsurance { get; set; }
        public DbSet<VehicleInsurance> VehicleInsurance { get; set; }
        public DbSet<WarehouseLocation> WarehouseLocation { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<DriverPermit> DriverPermit { get; set; }
        public DbSet<Remittance> Remittance { get; set; }
        public DbSet<Entry> Entry { get; set; }
        public DbSet<OperationState> OperationState { get; set; }
        public DbSet<Merchandise> Merchandise { get; set; }
        public DbSet<MerchandiseInsurance> MerchandiseInsurance { get; set; }
        public DbSet<Pallet> Pallet { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Address>().HasData(DbSeeder.SeedAddresses());
            builder.Entity<Client>().HasData(DbSeeder.SeedClients());
            builder.Entity<Driver>().HasData(DbSeeder.SeedDrivers());
            builder.Entity<VehicleInsurance>().HasData(DbSeeder.SeedVehicleInsurances());
            builder.Entity<TrailerInsurance>().HasData(DbSeeder.SeedTrailerInsurances());
            builder.Entity<Vehicle>().HasData(DbSeeder.SeedVehicles());
            builder.Entity<Trailer>().HasData(DbSeeder.SeedTrailers());
            builder.Entity<RTO>().HasData(DbSeeder.SeedRTO());
            builder.Entity<DriverPermit>().HasData(DbSeeder.SeedDriverPermits());
            builder.Entity<Dock>().HasData(DbSeeder.SeedDocks());
            base.OnModelCreating(builder);
        }
    }
}