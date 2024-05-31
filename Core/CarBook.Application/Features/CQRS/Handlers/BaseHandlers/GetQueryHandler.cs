using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public class GetQueryHandler<T, TRequest, TModel> : BaseHandler<T, TRequest, TModel> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public GetQueryHandler(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<TModel> Handle(TRequest request = default)
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<TModel>(entities);
        }
    }
}
