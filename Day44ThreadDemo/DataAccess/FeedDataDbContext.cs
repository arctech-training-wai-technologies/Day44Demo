using Day44ThreadDemo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Day44ThreadDemo.DataAccess;

public class FeedDataDbContext : DbContext
{
    public DbSet<Feed> Feeds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=FeedData;Integrated Security=True");
    }
}