using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsite.Application.Features.News.Commands.DeleteNews
{
    public class DeleteNewsCommand :IRequest<DeleteNewsVm>
    {
        public int NewsId { get; set; }   
    }
}
