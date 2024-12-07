namespace NewsWebSite.Components.Layout
{
    public partial class LatestNews
    {
        private List<string> AllNews;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            AllNews = new List<string>
            {
                "خبر جدید 1",
                "خبر جدید 2",
                "خبر جدید 3",
                "خبر جدید 4",
                "خبر جدید 5",
                "خبر جدید 6",
            };
        }
    }
}
