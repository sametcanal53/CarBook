using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _bannerRepository;

        public UpdateBannerCommandHandler(IRepository<Banner> bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var banner = await _bannerRepository.GetByIdAsync(command.BannerID);
            banner.Title = command.Title;
            banner.Description = command.Description;
            banner.VideoDescription = command.VideoDescription;
            banner.VideoUrl = command.VideoUrl;
            await _bannerRepository.UpdateAsync(banner);
        }
    }
}
