using AutoMapper;
using CarBook.Application.Interfaces;

namespace CarBook.Application.Features.CQRS.Handlers.BaseHandlers
{
    public class UpdateCommandHandler<T, TRequest, TModel> : BaseHandler<T, TRequest, TModel> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public UpdateCommandHandler(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<TModel> Handle(TRequest request)
        {
            var entity = await _repository.GetByIdAsync((int)typeof(TRequest).GetProperty($"{typeof(T).Name}ID").GetValue(request));
            UpdateProperties(request, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<TModel>(entity);
        }

        private void UpdateProperties(TRequest source, T destination)
        {
            var sourceProperties = source.GetType().GetProperties();
            var destinationProperties = destination.GetType().GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                var destinationProperty = destinationProperties.FirstOrDefault(p => p.Name == sourceProperty.Name && p.PropertyType == sourceProperty.PropertyType);

                if (destinationProperty != null && destinationProperty.CanWrite)
                {
                    var value = sourceProperty.GetValue(source);
                    destinationProperty.SetValue(destination, value);
                }
            }
        }
    }
}
