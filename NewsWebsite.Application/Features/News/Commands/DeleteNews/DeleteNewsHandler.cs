using MediatR;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Application.Features.News.Commands.DeleteNews;
using NewsWebsite.Persistence.Contexts;


namespace NewsWebsite.Application.Features.News.Commands
{
    public class DeleteNewsHandler(NewsWebsiteDbContext newsWebsiteDbContext) : IRequestHandler<DeleteNewsCommand, DeleteNewsVm>
    {
        public async Task<DeleteNewsVm> Handle(DeleteNewsCommand request, CancellationToken cancellationToken)
        {
           var news = await newsWebsiteDbContext.News.FirstOrDefaultAsync(n => n.NewsId == request.NewsId ,cancellationToken);
            if (news == null)
            {
                return new DeleteNewsVm
                {
                    Result = false,
                };
            }
            newsWebsiteDbContext.News.Remove(news);
            var result = await newsWebsiteDbContext.SaveChangesAsync(cancellationToken);    

            return new()
            {
                Result = false,
            };
        }
    }

}

