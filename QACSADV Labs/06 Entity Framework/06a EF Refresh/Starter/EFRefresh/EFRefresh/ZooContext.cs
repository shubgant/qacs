using System;
using System.Collections.Generic;
using System.Text;

namespace EFRefresh
{
    // TODO 3 uncomment ZooContext
    //public class ZooContext : DbContext { 
    //    public ZooContext(DbContextOptions<ZooContext> options) : base(options) { } // SqlServer

    //    public DbSet<Zoo> Zoos { get; set; }
    //    public DbSet<Animal> Animals { get; set; }

	//    // TODO 6 OnConfiguring
    //    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    //{
    //        //    //NuGet Microsoft.EntityFrameworkCore.Proxies
    //    //    optionsBuilder.UseLazyLoadingProxies();
    //    //}
    //}

    // TODO 7 Required for Design-Time creation of ZooContext (for Migration)
    //public class ZooContextFactory : IDesignTimeDbContextFactory<ZooContext>
    //{
    //    public ZooContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ZooContext>();
    //        string conn = @"Server=.\SqlExpress;Database=EFRefresh;Trusted_Connection=true; MultipleActiveResultSets=True";
    //        optionsBuilder.UseSqlServer(conn);

    //        return new ZooContext(optionsBuilder.Options);
    //    }
    //}
}
