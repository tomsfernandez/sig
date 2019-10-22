using System.Collections.Generic;
using Web.Models.Domain;

namespace Web.Models {
    public class MerchandiseControlViewModel {

        public long RemittanceId { get; set; }
        public List<Merchandise> Merchandises { get; set; }
        public long OperationStateId { get; set; }
    }
}