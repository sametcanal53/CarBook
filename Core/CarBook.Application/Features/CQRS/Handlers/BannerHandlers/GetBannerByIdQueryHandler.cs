using AutoMapper;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler : GetByIdQueryHandler<Banner, GetBannerByIdQuery, GetBannerByIdQueryResult>
    {
        public GetBannerByIdQueryHandler(IRepository<Banner> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
