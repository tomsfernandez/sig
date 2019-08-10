using System.ComponentModel.DataAnnotations;

namespace Web.Models {
    public class Brand {

        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}