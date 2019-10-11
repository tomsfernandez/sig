using System;

namespace Web.Models.Domain {
    public class RTO {

        public long Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public long VehicleId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CertifiedBy { get; set; }
    }
}