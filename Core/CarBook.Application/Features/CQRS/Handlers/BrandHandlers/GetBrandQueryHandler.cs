using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public GetBrandQueryHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _brandRepository.GetAllAsync();
            return values.Select(brand => new GetBrandQueryResult
            {
                BrandID = brand.BrandID,
                Name = brand.Name
            }).ToList();
        }
    }
}
