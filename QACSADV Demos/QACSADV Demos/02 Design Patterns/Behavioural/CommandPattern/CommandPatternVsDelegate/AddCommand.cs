using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternVsDelegate
{
    internal class AddCommand:ICommand
    {
        private readonly int a;
        private readonly int b;

        public AddCommand(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Execute()
        {
            Console.WriteLine($"Result of addition: {a + b}");
        }
    }
}
