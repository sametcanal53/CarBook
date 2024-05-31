using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public abstract class BaseHandler<T, TRequest, TModel> : IBaseHandler<TRequest, TModel> where T : class
    {
        public abstract Task<TModel> Handle(TRequest request);
    }
}
