namespace PaymentAPI.Interfaces
{
    public interface IMessagePublisher
    {
        Task PublishMessage<T>(T message);  
    }
}