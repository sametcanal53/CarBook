namespace CarBook.Application.Interfaces
{
    public interface IBaseHandler<TRequest, TModel>
    {
        Task<TModel> Handle(TRequest request);
    }
}
