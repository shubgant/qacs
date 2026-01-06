using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // The 'Product' class
    public class Car
    {
        private List<string> _parts = new List<string>();
        public CarType Type { get; set; }
        public void Add(string part) => _parts.Add(part);
        public void Show(){
            Console.WriteLine($"\n{this.Type} Car\n\tProduct Parts -------");
            _parts.ForEach(part => Console.WriteLine($"\t{part}"));
        }
    }
}
