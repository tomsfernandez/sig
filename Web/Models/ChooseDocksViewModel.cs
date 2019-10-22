using System.Collections.Generic;
using Web.Models.Domain;

namespace Web.Models {
    public class ChooseDocksViewModel {
        public long OperationId { get; set; }
        public List<Dock> Docks { get; set; }
    }
}