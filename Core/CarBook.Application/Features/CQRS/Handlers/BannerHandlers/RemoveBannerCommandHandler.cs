using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler : RemoveCommandHandler<Banner, RemoveBannerCommand, object>
    {
        public RemoveBannerCommandHandler(IRepository<Banner> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
