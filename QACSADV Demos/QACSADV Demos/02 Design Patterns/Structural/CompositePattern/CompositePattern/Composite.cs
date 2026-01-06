using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }
        public override void Add(Component component) => _children.Add(component);
        public override void Remove(Component component) => _children.Remove(component);
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            _children.ForEach(comp => comp.Display(depth + 2));
        }
    }
}
