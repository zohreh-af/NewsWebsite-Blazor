using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NewsWebsite.Application.Features.News.Commands.UpdateNews;
using NewsWebsite.Persistence.Contexts;
using NewsWebsite.Shared.Extensions;

namespace NewsWebsite.Application.Features.News.Commands.InsertNews
{
    public class InsertNewsHandler(NewsWebsiteDbContext newsWebsiteDbContext
        , IMapper mapper
        , IHttpContextAccessor httpContextAccessor
        , ILogger<InsertNewsHandler> logger
        , IMediator mediator) : IRequestHandler<InsertNewsCommand, InsertNewsVm>
    {
        public async Task<InsertNewsVm> Handle(InsertNewsCommand request, CancellationToken cancellationToken)
        {
            if (await newsWebsiteDbContext.News.AnyAsync(p => p.NewsId == request.NewsId))
            {
                var news = mapper.Map<UpdateNewsCommand>(request);
                return new()
                {
                    Result = (await mediator.Send<UpdateNewsVm>(news)).Result
                };
            }
            try
            {
                //using var transaction = await newsWebsiteDbContext.Database.BeginTransactionAsync();
                // i dont need this now, when our method effect more than one entity we use this in case of faulure in any part.

                var news = mapper.Map<Domains.Entities.News>(request);
                news.IsActive = true;
                news.Create = DateTime.Now;
                news.CreatedBy = httpContextAccessor.HttpContext.User.GetUserId();

                await newsWebsiteDbContext.AddAsync(news);
                await newsWebsiteDbContext.SaveChangesAsync();

                return new()
                {
                    Result = true,
                };



            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, ex.Message);
                return new()
                {
                    Result = false,
                };
            }
        }
    }
}