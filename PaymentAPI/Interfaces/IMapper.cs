namespace PaymentAPI.Interfaces
{
    public interface IMapper<TEntity, TModel>
    {
        TEntity MapToEntity(TModel model);
    }
}