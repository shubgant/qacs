using Microsoft.EntityFrameworkCore;

namespace NorthWindWebAPI.Models
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options): base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
