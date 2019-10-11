using System;

namespace Web.Models.Domain {
    public class RUTA {

        public long Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public long VehicleId { get; set; }
        public Client Client { get; set; }
        public long ClientId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Category { get; set; }
    }
}