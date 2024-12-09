
using MediatR;
namespace NewsWebsite.Application.Features.News.Queries
{
    public class GetNewsByIdQuery : IRequest<GetNewsByIdVm>
    {
        public int Id { get; set; }  
    }
}
