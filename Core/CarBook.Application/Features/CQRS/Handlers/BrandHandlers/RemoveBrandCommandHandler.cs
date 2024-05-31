using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler : RemoveCommandHandler<Brand, RemoveBrandCommand, object>
    {
        public RemoveBrandCommandHandler(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
