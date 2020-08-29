using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AthenaeumLibrary;

namespace Athenaeum
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base()
        {
        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<BookModel> Books { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
    }
}
