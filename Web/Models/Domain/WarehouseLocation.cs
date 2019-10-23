namespace Web.Models.Domain {
    public class WarehouseLocation {
        public long Id { get; set; }
        public string Section { get; set; }
        public string Aisle { get; set; }
        public string Position { get; set; }
        public string Level { get; set; }

        public string ToString() {
            return $"Cod {Id}, Sección {Section}, Pasillo {Aisle}, Posición {Position}, Nivel {Level}";
        }
    }
}