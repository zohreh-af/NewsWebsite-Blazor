using AutoMapper;
using MediatR;
using NewsWebsite.Persistence.Contexts;

namespace NewsWebsite.Application.Features.News.Queries.GetNewsByTitle
{
    public class GetNewsByTitleHandler(NewsWebsiteDbContext newsWebsiteDbContext
        , IMapper mapper) : IRequestHandler<GetNewsByTitleQuery, GetNewsByTitleVm>
    {
        public Task<GetNewsByTitleVm> Handle(GetNewsByTitleQuery request, CancellationToken cancellationToken)
        {
           var news = newsWebsiteDbContext.News
                .Where(p => p.Title != null && p.Title.ToLower().Contains(request.Title.ToLower()))
                .FirstOrDefault();
            if (news != null)
            {
                return null;
            }
            return mapper.Map<GetNewsByTitleVm>(news);

        }
    }

}
