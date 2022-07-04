using PaymentAPI.Interfaces;

namespace PaymentAPI.Infrastructure.SNS
{
    public class SnsPublisher : IMessagePublisher
    {
        public Task PublishMessage<T>(T message)
        {
            throw new NotImplementedException();
        }
    }
}
