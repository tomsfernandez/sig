using Web.Models.Domain;

namespace Web.Models {
    public class SecurityViewModel
    {
        public Entry Entry { get; set; }
        public DriverPermit DriverPermit { get; set; }

        public long ExitConfirmation { get; set; }

        public bool CanExit { get; set; }
        public bool CanEnter { get; set; }
    }
}