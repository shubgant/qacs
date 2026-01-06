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
        static void Main(string[] args)
        {
            List<Zoo> zoos = new List<Zoo>();
            Zoo londonZoo = new Zoo() { Name = "London" };
            Zoo edinburghZoo = new Zoo() { Name = "Edinburgh" };
            zoos.Add(londonZoo);
            zoos.Add(edinburghZoo);
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Dumbo" });
            londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Heffalumps" });
            londonZoo.Animals.Add(new Animal() { Type = "Lion", Name = "Clarence" }); // Lion tamer = Claude Bottom
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sweetie" });
            edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sunshine" });

            foreach (Zoo zoo in zoos)
            {
                Console.WriteLine($"\nName = {zoo.Name}, number of animals = {zoo.Animals.Count()}");
                foreach (Animal animal in zoo.Animals)
                {
                    Console.WriteLine($"...{animal.Type,-10}{animal.Name}");
                    // TODO 1 Console.WriteLine($"......in zoo {animal.Zoo.Name}");
                }
            }
            Console.WriteLine();
        }

        // TODO 5 AddSampleData
        //private static void AddSampleData(ZooContext ctx)
        //{
        //    Zoo londonZoo = new Zoo() { Name = "London" };
        //    Zoo edinburghZoo = new Zoo() { Name = "Edinburgh" };
        //    londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Dumbo" });
        //    londonZoo.Animals.Add(new Animal() { Type = "Elephant", Name = "Heffalumps" });
        //    londonZoo.Animals.Add(new Animal() { Type = "Lion", Name = "Clarence" }); // Lion tamer = Claude Bottom
        //    edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sweetie" });
        //    edinburghZoo.Animals.Add(new Animal() { Type = "Panda", Name = "Sunshine" });
        //    ctx.Zoos.Add(londonZoo);
        //    ctx.Zoos.Add(edinburghZoo);
        //    ctx.SaveChanges();
        //}
    }

}
