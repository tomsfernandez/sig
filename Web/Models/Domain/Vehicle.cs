namespace Web.Models.Domain {
    public class Vehicle {

        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Type { get; set; }
        public VehicleInsurance Insurance { get; set; }
        public long VehicleInsuranceId { get; set; }
    }
}