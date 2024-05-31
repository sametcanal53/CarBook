using AutoMapper;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Handlers.BaseHandlers;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler : CreateCommandHandler<Brand, CreateBrandCommand, object>
    {
        public CreateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
