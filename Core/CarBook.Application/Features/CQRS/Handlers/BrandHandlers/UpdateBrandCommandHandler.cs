using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler : UpdateCommandHandler<Brand, UpdateBrandCommand, object>
    {
        public UpdateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
