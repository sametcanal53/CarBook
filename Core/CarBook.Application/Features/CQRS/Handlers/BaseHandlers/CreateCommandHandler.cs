using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public class CreateCommandHandler<T, TRequest, TModel> : BaseHandler<T, TRequest, TModel> where T : class 
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public CreateCommandHandler(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<TModel> Handle(TRequest request)
        {
            var entity = _mapper.Map<T>(request);
            await _repository.CreateAsync(_mapper.Map<T>(request));
            return _mapper.Map<TModel>(entity);
        }
    }
}
