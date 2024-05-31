using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler : RemoveCommandHandler<About, RemoveAboutCommand, object>
    {
        public RemoveAboutCommandHandler(IRepository<About> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
