using Microsoft.EntityFrameworkCore;

namespace Context.Razor.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserTaskModel> UsersTask { get; set; }
    }
}
