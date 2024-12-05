using Microsoft.EntityFrameworkCore;
using NewsWebsite.Domains.Entities;


namespace NewsWebsite.Persistence.Contexts
{
    public class NewsWebsiteDbContext : DbContext
    {

        public NewsWebsiteDbContext(DbContextOptions<NewsWebsiteDbContext> options) : base(options)
        {

        }

        public DbSet<News> News { get; set; }


    }
}
