using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public RemoveBannerCommandHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public async Task Handle(RemoveBannerCommand command)
        {
            var banner = await _bannerRepository.GetByIdAsync(command.Id);
            await _bannerRepository.RemoveAsync(banner);
        }
    }
}
