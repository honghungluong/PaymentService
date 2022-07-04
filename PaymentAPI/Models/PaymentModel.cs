using PaymentAPI.Enums;

namespace PaymentAPI.Models
{
    public class PaymentModel
    {
        public Guid PaymentId { get; set; } = Guid.NewGuid();
        public Guid ShipperId { get; set; } = Guid.NewGuid();
        public Guid CarrierId { get; set; } = Guid.NewGuid();
        public decimal PriceTotal { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime LastUpdatedDateUtc { get; set; }
        public Guid LastUpdatedBy { get; set; } = Guid.NewGuid();  // chi v ?

    }
}
