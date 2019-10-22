using System.Collections.Generic;

namespace Web.Models.Domain {
    public class Merchandise {
        
        public long Id { get; set; }
        public string Description { get; set; }
        public string ExternCode { get; set; }
        public int TotalBoxes { get; set; }
        public double BoxHeight { get; set; }
        public double BoxWidth { get; set; }
        public double BoxLength { get; set; }
        public double BoxWeight { get; set; }
        public Remittance Remittance { get; set; }
        public long RemittanceId { get; set; }

        public int RequestedPallets { get; set; }
        public List<Pallet> Pallets { get; set; }
    }
}