using System;

namespace Web.Models.Domain {
    public class Address {

        public long Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string StreetHeight { get; set; }

        public string ToString() {
            return $"{Street} - ${StreetHeight}, {City}, {Country}";
        }
    }
}