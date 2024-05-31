using AutoMapper;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler : GetByIdQueryHandler<Brand, GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        public GetBrandByIdQueryHandler(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
