using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public UpdateAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var about = await _aboutRepository.GetByIdAsync(command.AboutID);
            about.Title = command.Title;
            about.Description = command.Description;
            about.ImageUrl = command.ImageUrl;
            await _aboutRepository.UpdateAsync(about);
        }
    }
}
