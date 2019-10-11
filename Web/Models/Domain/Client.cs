namespace Web.Models.Domain {
    public class Client {

        public long Id { get; set; }
        public string BusinessName { get; set; }
        public string Cuit { get; set; }
        public Address Address { get; set; }
        public long AddressId { get; set; }
    }
}