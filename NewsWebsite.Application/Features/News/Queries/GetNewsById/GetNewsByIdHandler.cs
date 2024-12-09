using AutoMapper;
using MediatR;
using NewsWebsite.Persistence.Contexts;

namespace NewsWebsite.Application.Features.News.Queries
{
    public class GetNewsByIdHandler(NewsWebsiteDbContext newsWebsiteDbContext,
        IMapper mapper) : IRequestHandler<GetNewsByIdQuery, GetNewsByIdVm>
    {
        public async Task<GetNewsByIdVm> Handle(GetNewsByIdQuery request, CancellationToken cancellationToken)
        
           =>  mapper.Map<GetNewsByIdVm>(newsWebsiteDbContext.News.FirstOrDefault(p => p.NewsId == request.Id));
                
        
    }
}
