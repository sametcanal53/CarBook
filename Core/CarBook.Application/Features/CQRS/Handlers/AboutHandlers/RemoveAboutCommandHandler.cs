using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public RemoveAboutCommandHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task Handle(RemoveAboutCommand command)
        {
            var about = await _aboutRepository.GetByIdAsync(command.Id);
            await _aboutRepository.RemoveAsync(about);
        }
    }
}
