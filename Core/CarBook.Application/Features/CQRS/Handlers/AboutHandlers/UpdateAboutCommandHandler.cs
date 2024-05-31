using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : UpdateCommandHandler<About, UpdateAboutCommand, object>
    {
        public UpdateAboutCommandHandler(IRepository<About> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
