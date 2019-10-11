using System;

namespace Web.Models.Domain {
    public class OperationState {

        public long Id { get; set; }
        public string RemittanceState { get; set; }
        public string MerchandiseState { get; set; }
        public Remittance Remittance { get; set; }
        public long RemittanceId { get; set; }
        public Entry Entry { get; set; }
        public long EntryId { get; set; }
        public Dock Dock { get; set; }
        public long DockId { get; set; }
    }
}