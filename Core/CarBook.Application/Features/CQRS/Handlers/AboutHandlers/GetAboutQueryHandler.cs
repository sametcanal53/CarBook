using AutoMapper;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler : GetQueryHandler<About, object, List<GetAboutQueryResult>>
    {
        public GetAboutQueryHandler(IRepository<About> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
