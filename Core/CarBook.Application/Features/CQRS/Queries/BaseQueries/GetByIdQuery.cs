namespace CarBook.Application.Features.CQRS.Queries.Queries
{
    public class GetByIdQuery
    {
        public GetByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
