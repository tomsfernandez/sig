using System;

namespace Web.Models.Domain {
    public class DriverPermit {

        public long Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public long VehicleId { get; set; }
        public Driver Driver { get; set; }
        public long DriverId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}