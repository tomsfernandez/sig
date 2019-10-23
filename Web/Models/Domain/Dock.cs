using System;

namespace Web.Models.Domain {
    public class Dock {
        public long Id { get; set; }
        public bool Occupied { get; set; }

        public string ToString() {
            return $"Dock nro {Id} - ocupado: {Occupied}";
        }
    }
}