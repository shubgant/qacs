using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

// TODO 2 NuGet:
// Microsoft.Extensions.DependencyInjection
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.EntityFrameworkCore.Tools

namespace EFRefresh
{
    class Program
    {
        public static ServiceCollection services;
        public static ServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            ConfigureServices();
            Configure();

            //List<Zoo> zoos = new List<Zoo>();
            //Zoo londonZoo = new Zoo() { Name = "London" };
            //Zoo edinburghZoo = new Zoo() { Name = "Edinburgh" };
            //zoos.Add(londonZoo);
            //zoos.Add(edinburghZoo);
            //londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Dumbo" });
            //londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Heffalumps" });
            //londonZoo.Animals.Add(new Animal() { Type = "Lion", Name = "Clarence" }); // Lion tamer = Claude Bottom
            //edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sweetie" });
            //edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sunshine" });


            //Console.WriteLine();
        }

        private static void Configure()
        {
            ZooContext ctx = serviceProvider.GetService<ZooContext>();

            //ctx?.Database.EnsureDeleted();
            //ctx?.Database.EnsureCreated();
            //AddSampleData(ctx);


            foreach (Zoo zoo in ctx.Zoos)
            {
                ctx.Entry(zoo).Collection(z => z.Animals).Load();
                Console.WriteLine($"\nName = {zoo.Name}, number of animals = {zoo.Animals.Count()}");
                foreach (Animal animal in zoo.Animals)
                {
                    Console.WriteLine($"...{animal.Type,-10}{animal.Name}");
                    Console.WriteLine($"......in zoo {animal.Zoo.Name}");
                }
            }
        }

        private static void ConfigureServices()
        {
            services = new ServiceCollection();
            string conn = @"Server=.\SQLExpress;Encrypt=False;AttachDbFileName=C:\Temp\MyDataFile.mdf;Database=EFRefresh;Trusted_Connection=true;MultipleActiveResultSets=True";
            services.AddDbContext<ZooContext>(options => options.UseSqlServer(conn));
            serviceProvider = services.BuildServiceProvider();

        }

        // TODO 5 AddSampleData
        private static void AddSampleData(ZooContext ctx)
        {
            Zoo londonZoo = new Zoo() { Name = "London" };
            Zoo edinburghZoo = new Zoo() { Name = "Edinburgh" };
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Dumbo" });
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Heffalumps" });
            londonZoo.Animals.Add(new Animal() { Type = "Lion", Name = "Clarence" }); // Lion tamer = Claude Bottom
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sweetie" });
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sunshine" });
            ctx.Zoos.Add(londonZoo);
            ctx.Zoos.Add(edinburghZoo);
            ctx.SaveChanges();
        }
    }

}
