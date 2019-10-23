using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.Extensions;
using Web.Models.Domain;

namespace Web.Data {
    public class DbSeeder {

        public static List<Driver> SeedDrivers(int amount = 10) {
            var ids = 1L;
            var drivers = new Faker<Driver>()
                .StrictMode(true)
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.Dni, f => f.Internet.Ip())
                .RuleFor(d => d.Name, f => f.Name.FirstName())
                .RuleFor(d => d.LastName, f => f.Name.LastName());
            return drivers.GenerateForever().Take(amount).ToList();
        }

        public static List<Client> SeedClients(int amount = 10) {
            var ids = 1L;
            var addressIds = 1L;
            var clients = new Faker<Client>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.BusinessName, f => f.Company.CompanyName())
                .RuleFor(d => d.Cuit, f => f.Commerce.Ean8())
                .RuleFor(d => d.AddressId, f => addressIds++);
            return clients.GenerateForever().Take(amount).ToList();
        }

        public static List<Address> SeedAddresses(int amount = 10) {
            var ids = 1L;
            var addresses = new Faker<Address>()
                .StrictMode(true)
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.City, f => f.Address.City())
                .RuleFor(d => d.Street, f => f.Address.StreetName())
                .RuleFor(d => d.StreetHeight, f => f.Address.BuildingNumber())
                .RuleFor(d => d.Country, f => f.Address.Country());
            return addresses.GenerateForever().Take(amount).ToList();
        }

        public static List<VehicleInsurance> SeedVehicleInsurances(int amount = 10) {
            var ids = 1L;
            var insurances = new Faker<VehicleInsurance>()
                .StrictMode(true)
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(i => i.PolicyNumber, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(i => i.InsuranceBusinessName, f => f.Company.CompanyName())
                .RuleFor(i => i.ExpirationDate, f => f.Date.Future());
            return insurances.GenerateForever().Take(amount).ToList();
        }

        public static List<TrailerInsurance> SeedTrailerInsurances(int amount = 10) {
            var ids = 1L;
            var insurances = new Faker<TrailerInsurance>()
                .StrictMode(true)
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(i => i.PolicyNumber, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(i => i.InsuranceBusinessName, f => f.Company.CompanyName())
                .RuleFor(i => i.ExpirationDate, f => f.Date.Future());
            return insurances.GenerateForever().Take(amount).ToList();
        }

        public static List<Vehicle> SeedVehicles(int amount = 10) {
            var ids = 1L;
            var insuranceIds = 1L;
            var vehicles = new Faker<Vehicle>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(i => i.Brand, f => f.Vehicle.Manufacturer())
                .RuleFor(i => i.Model, f => f.Vehicle.Model())
                .RuleFor(i => i.Type, f => f.Vehicle.Type())
                .RuleFor(i => i.LicensePlate, f => f.Address.ZipCode())
                .RuleFor(i => i.VehicleInsuranceId, f => insuranceIds++);
            return vehicles.GenerateForever().Take(amount).ToList();
        }

        public static List<Trailer> SeedTrailers(int amount = 10) {
            var ids = 1L;
            var insuranceIds = 1L;
            var trailers = new Faker<Trailer>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(i => i.LicensePlate, f => f.Address.ZipCode())
                .RuleFor(i => i.TrailerInsuranceId, f => insuranceIds++);
            return trailers.GenerateForever().Take(amount).ToList();
        }

        public static List<RTO> SeedRTO(int amount = 10) {
            var ids = 1L;
            var vehicles = 1L;
            var rtoS = new Faker<RTO>()
                .RuleFor(r => r.Id, f => ids++)
                .RuleFor(r => r.CertifiedBy, "Ministerio de Transporte")
                .RuleFor(r => r.ExpirationDate, f => f.Date.Future())
                .RuleFor(r => r.VehicleId, f => vehicles++);
            return rtoS.GenerateForever().Take(amount).ToList();
        }

        public static List<DriverPermit> SeedDriverPermits(int amount = 10) {
            var ids = 1L;
            var vehicles = 1L;
            var drivers = 1L;
            var permits = new Faker<DriverPermit>()
                .RuleFor(r => r.Id, f => ids++)
                .RuleFor(r => r.ExpirationDate, f => f.Date.Future())
                .RuleFor(r => r.VehicleId, f => vehicles++)
                .RuleFor(r => r.DriverId, f => drivers++);
            return permits.GenerateForever().Take(amount).ToList();
        }

        public static List<Dock> SeedDocks(int amount = 10) {
            var ids = 1L;
            var docks = new Faker<Dock>()
                .StrictMode(true)
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.Occupied, f => false);
            return docks.GenerateForever().Take(amount).ToList();
        }
        
        public static List<Remittance> SeedRemittances(int amount = 10)
        {
            var ids = 1L;
            var clientIds = 1L;
            var remittances = new Faker<Remittance>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.DeliveryType, "Transporte de carga")
                .RuleFor(d => d.Date, f => f.Date.Soon())
                .RuleFor( d => d.ClientId, f => clientIds);
            return remittances.GenerateForever().Take(amount).ToList();
        }

        public static List<Entry> SeedEntries(int amount = 10)
        {
            var ids = 1L;
            var remittanceIds = 1L;
            var driverIds = 1L;
            var vehicleIds = 1L;
            var trailerIds = 1L;
            var entries = new Faker<Entry>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.RemittanceId, f => remittanceIds++)
                .RuleFor(d => d.DriverId, f => driverIds++)
                .RuleFor(d => d.VehicleId, f => vehicleIds++)
                .RuleFor(d => d.TrailerId, f => trailerIds++);
            return entries.GenerateForever().Take(amount).ToList();
        }
        
        
        // TODO merchandise
        public static List<Merchandise> SeedMerchandises(int amount = 10)
        {
            var ids = 1L;
            var remittanceIds = 1L;
            var merchandise = new Faker<Merchandise>()
                .RuleFor(d => d.Id, f => ids++)
                .RuleFor(d => d.Description, f => f.Commerce.ProductAdjective())
                .RuleFor(d => d.ExternCode, f => f.Commerce.Ean8())
                .RuleFor( d => d.RequestedPallets, 10)
                .RuleFor(d => d.TotalBoxes, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(d => d.BoxHeight, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(d => d.BoxWidth, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(d => d.BoxLength, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(d => d.BoxWeight, f => int.Parse(f.Commerce.Ean8()))
                .RuleFor(d => d.RemittanceId, f => remittanceIds);

            return merchandise.GenerateForever().Take(amount).ToList();
        }
        
        public static List<WarehouseLocation> SeedWarehouseLocations()
        {
            var ids = 1L;
            
            var warehouseLocation = new Faker<WarehouseLocation>();


            return warehouseLocation.GenerateForever().Take(10).ToList();
        }
        
        // TODO pallet
    }
}