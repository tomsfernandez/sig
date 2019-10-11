using System;

namespace Web.Models.Domain {
    public class TrailerInsurance {

        public long Id { get; set; }
        public int PolicyNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string InsuranceBusinessName { get; set; }
    }
}