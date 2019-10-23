using System.Data;

namespace Web.Models.Domain {
    public class Driver {

        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }

        public string ToString() {
            return $"{LastName}, {Name} - {Dni}";
        }
    }
}