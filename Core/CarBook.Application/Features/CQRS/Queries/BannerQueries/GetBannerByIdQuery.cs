using CarBook.Application.Features.CQRS.Queries.Queries;

namespace CarBook.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery : GetByIdQuery
    {
        public GetBannerByIdQuery(int id) : base(id)
        {
        }
    }
}
