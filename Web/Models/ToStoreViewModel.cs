using Web.Models.Domain;

namespace Web.Controllers {
    public class ToStoreViewModel {
        public long PalletId { get; set; }
        public WarehouseLocation WarehouseLocation { get; set; }
        public long ConfirmedLocationId { get; set; }
    }
}