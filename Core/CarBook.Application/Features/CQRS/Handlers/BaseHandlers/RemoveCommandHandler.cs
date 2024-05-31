using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public class RemoveCommandHandler<T, TRequest, TModel> : BaseHandler<T, TRequest, TModel> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public RemoveCommandHandler(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<TModel> Handle(TRequest request)
        {
            var entity = await _repository.GetByIdAsync((int)typeof(TRequest).GetProperty("Id").GetValue(request));
            await _repository.RemoveAsync(entity);
            return _mapper.Map<TModel>(entity);
        }
    }
}
