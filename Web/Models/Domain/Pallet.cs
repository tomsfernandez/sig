using System;

namespace Web.Models.Domain {
    public class Pallet {

        public enum PalletStates {
            Downloaded, Staged, Stored
        }
        public long Id { get; set; }
        public int AmountOfBoxes { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime EntryTimestamp { get; set; }
        public DateTime ExitTimestamp { get; set; }
        public string State { get; set; } = PalletStates.Downloaded.ToString();
        public WarehouseLocation WarehouseLocation { get; set; }
        public long WarehouseLocationId { get; set; }
        public Merchandise Merchandise { get; set; }
        public long MerchandiseId { get; set; }
    }
}