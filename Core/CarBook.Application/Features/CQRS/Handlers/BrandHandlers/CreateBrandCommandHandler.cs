﻿using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public CreateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateBrandCommand command)
        {
            await _brandRepository.CreateAsync(new Brand
            {
                Name = command.Name
            });
        }
    }
}
