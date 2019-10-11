namespace Web.Models.Domain {
    public class Trailer {

        public long Id { get; set; }
        public string LicensePlate { get; set; }
        public TrailerInsurance Insurance { get; set; }
        public long TrailerInsuranceId { get; set; }
    }
}