using AutoMapper;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : GetByIdQueryHandler<About, GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        public GetAboutByIdQueryHandler(IRepository<About> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
