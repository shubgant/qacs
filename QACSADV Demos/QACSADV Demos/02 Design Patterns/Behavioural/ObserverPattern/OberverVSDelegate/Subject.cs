using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverVSDelegate
{
    internal class Subject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private int state;

        public int State
        {
            get => state;
            set
            {
                state = value;
                NotifyObservers();
            }
        }

        public void Attach(IObserver observer) => observers.Add(observer);
        public void Detach(IObserver observer) => observers.Remove(observer);

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(state);
            }
        }
    }
}
