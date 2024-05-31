using AutoMapper;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : GetQueryHandler<Brand, object, List<GetBrandQueryResult>>
    {
        public GetBrandQueryHandler(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
