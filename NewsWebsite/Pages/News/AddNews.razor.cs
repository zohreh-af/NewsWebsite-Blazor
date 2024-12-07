using Microsoft.AspNetCore.Components;
using NewsWebSite.DTO.Newses;
using NewsWebSite.Service;

namespace NewsWebSite.Components.Pages.News
{
    public partial class AddNews
    {
        [Inject]
        public INewsService NewsService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        public NewsDTO NewsModel { get; set; } = new NewsDTO();
        private async Task HandelCreateNews()
        {
            var IsDuplicateNews = await NewsService.IsExistingByTitle(NewsModel.Title);
            if (IsDuplicateNews != null)
            {
                return;
            }
            var CreateResult = await NewsService.CreateNews(NewsModel);
            navigationManager.NavigateTo("newses");
            


        }

    }
}
