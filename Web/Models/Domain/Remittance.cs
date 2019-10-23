using System;
using System.Collections.Generic;

namespace Web.Models.Domain {
    public class Remittance {

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryType { get; set; }
        public Client Client { get; set; }
        public long ClientId { get; set; }
        public List<Merchandise> Merchandise { get; set; } = new List<Merchandise>();
        public OperationState OperationState { get; set; }

        public string ToString() {
            return $"Remito para ${Date} con entrega tipo {DeliveryType}";
        }
    }
}