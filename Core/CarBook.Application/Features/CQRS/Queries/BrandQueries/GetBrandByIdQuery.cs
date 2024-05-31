using CarBook.Application.Features.CQRS.Queries.Queries;

namespace CarBook.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery : GetByIdQuery
    {
        public GetBrandByIdQuery(int id) : base(id)
        {
        }
    }
}
