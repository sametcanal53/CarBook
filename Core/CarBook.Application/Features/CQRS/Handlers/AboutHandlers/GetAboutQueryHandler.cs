using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public GetAboutQueryHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _aboutRepository.GetAllAsync();
            return values.Select(about => new GetAboutQueryResult
            {
                AboutID = about.AboutID,
                Title = about.Title,
                Description = about.Description,
                ImageUrl = about.ImageUrl
            }).ToList();
        }
    }
}
