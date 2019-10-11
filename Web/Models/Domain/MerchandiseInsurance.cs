using System;

namespace Web.Models.Domain {
    public class MerchandiseInsurance {

        public long Id { get; set; }
        public int PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public string SafetyMeasures { get; set; }
        public string InsuredMerchandise { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string InsuranceBusinessName { get; set; }
        public Remittance Remittance { get; set; }
        public long RemittanceId { get; set; }
    }
}