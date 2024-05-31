using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public class GetByIdQueryHandler<T, TRequest,TModel> : BaseHandler<T, TRequest, TModel> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<TModel> Handle(TRequest request)
        {
            var value = await _repository.GetByIdAsync((int)typeof(TRequest).GetProperty("Id").GetValue(request));
            return _mapper.Map<TModel>(value);
        }
    }
}
