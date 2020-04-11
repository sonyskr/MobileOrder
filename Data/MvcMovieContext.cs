using Microsoft.EntityFrameworkCore;
using MobileOrder.Models;

namespace MobileOrder.Data
{
    public class MobileOrderContext : DbContext
    {
        public MobileOrderContext (DbContextOptions<MobileOrderContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}