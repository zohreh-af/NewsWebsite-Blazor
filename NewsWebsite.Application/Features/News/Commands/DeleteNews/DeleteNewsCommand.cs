using MediatR;
namespace NewsWebsite.Application.Features.News.Commands.DeleteNews
{
    public class DeleteNewsCommand :IRequest<DeleteNewsVm>
    {
        public int NewsId { get; set; }   
    }
}
