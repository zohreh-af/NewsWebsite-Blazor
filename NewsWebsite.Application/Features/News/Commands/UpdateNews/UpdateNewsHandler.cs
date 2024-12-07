using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NewsWebsite.Application.Features.News.Commands;
using NewsWebsite.Application.Features.News.Commands.UpdateNews;
using NewsWebsite.Persistence.Contexts;
using NewsWebsite.Shared.Extensions;

namespace NewsWebsite.Application.Features.News
{
    public class UpdateNewsHandler(NewsWebsiteDbContext newsWebsiteDbContext
        , IMapper mapper
        , IHttpContextAccessor httpContextAccessor) : IRequestHandler<UpdateNewsCommand, UpdateNewsVm>
    {
        public async Task<UpdateNewsVm> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var news = await newsWebsiteDbContext.News.FirstOrDefaultAsync(p => p.NewsId == request.NewsId);
            if (news is null)
            {
                return new()
                {
                    Result = false,
                };
            }
            news.Title = request.Title; 
            news.Description = request.Description; 
            news.ShortDescription = request.ShortDescription;   
            news.ImageName = request.ImageName; 
            news.IsActive = request.IsActive;
            news.EditedBy = httpContextAccessor.HttpContext.User.GetUserId();
            newsWebsiteDbContext.Update(news);
            return new()
            {
                Result = true
            };

        }
    }

}
