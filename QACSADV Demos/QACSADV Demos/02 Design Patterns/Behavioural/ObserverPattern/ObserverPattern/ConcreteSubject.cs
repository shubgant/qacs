using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // The 'ConcreteSubject' class
    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }
}
