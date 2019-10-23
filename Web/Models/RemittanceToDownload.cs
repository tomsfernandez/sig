using Web.Models.Domain;

namespace Web.Models {
    public class RemittanceToDownload {

        public long Id { get; set; }
        public string ClientName { get; set; }
        public string DeliveryType { get; set; }
        public string State { get; set; }
        public string Dock { get; set; }
        public bool InDownload { get; set; }
    }
}