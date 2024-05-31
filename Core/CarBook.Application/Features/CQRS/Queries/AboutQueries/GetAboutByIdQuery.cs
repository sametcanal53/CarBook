using CarBook.Application.Features.CQRS.Queries.Queries;

namespace CarBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery : GetByIdQuery
    {
        public GetAboutByIdQuery(int id) : base(id)
        {
        }
    }
}
