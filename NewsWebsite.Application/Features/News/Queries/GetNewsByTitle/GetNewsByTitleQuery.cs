using MediatR;
using NewsWebsite.Application.Features.News.Queries;


namespace NewsWebsite.Application.Features.News.Queries.GetNewsByTitle
{
    public class GetNewsByTitleQuery :IRequest<GetNewsByTitleVm>
    {
        public string Title { get; set; }
    }
}
