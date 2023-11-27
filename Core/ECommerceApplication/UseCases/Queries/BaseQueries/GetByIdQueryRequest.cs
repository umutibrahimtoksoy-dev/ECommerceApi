using MediatR;

namespace ECommerceApplication.UseCases.Queries.BaseQueries
{
    public class GetByIdQueryRequest<T> : IRequest<T> where T : class
    {
        public int Id { get; set; }

        public GetByIdQueryRequest(int id)
        {
            Id = id;
        }

        public GetByIdQueryRequest()
        {

        }
    }
}
