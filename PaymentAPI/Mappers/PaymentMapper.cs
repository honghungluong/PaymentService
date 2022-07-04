using PaymentAPI.Models;
using PaymentAPI.Entities;
using PaymentAPI.Enums;
using PaymentAPI.Interfaces;

namespace PaymentAPI.Mappers
{
    public class PaymentMapper: IPaymentMapper
    {

        public Payment MapToEntity(PaymentModel paymentModel)
        {
            if(paymentModel == null)
            {
                return null;
            }

            try
            {
                var paymentEntity = new Payment
                {
                    PaymentId = paymentModel.PaymentId,
                    ShipperId = paymentModel.ShipperId,
                    CarrierId = paymentModel.CarrierId,
                    PriceTotal = paymentModel.PriceTotal,
                    Status = Enum.Parse<PaymentStatus>(paymentModel.Status),
                    CreatedDateUtc = paymentModel.CreatedDateUtc,
                    LastUpdatedDateUtc = paymentModel.LastUpdatedDateUtc,
                    LastUpdatedBy = paymentModel.LastUpdatedBy
                };
                return paymentEntity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
