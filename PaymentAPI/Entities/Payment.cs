using PaymentAPI.Enums;

namespace PaymentAPI.Entities
{
    public class Payment
    {
        public Guid PaymentId { get; set; } 
        public Guid ShipperId { get; set; } 
        public Guid CarrierId { get; set; } 
        public decimal PriceTotal { get; set; }
        public bool Deleted { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime LastUpdatedDateUtc { get; set; }
        public Guid LastUpdatedBy { get; set; }

    }
}
