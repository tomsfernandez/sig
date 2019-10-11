using System;

namespace Web.Models.Domain {
    public class Entry {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public Remittance Remittance { get; set; }
        public long RemittanceId { get; set; }
        public Driver Driver { get; set; }
        public long DriverId { get; set; }
        public Vehicle Vehicle { get; set; }
        public long VehicleId { get; set; }
        public Trailer Trailer { get; set; }
        public long TrailerId { get; set; }
    }
}