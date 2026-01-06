using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverVSDelegate
{
    internal class SubjectWithDelegate
    {
        public delegate void StateChangedHandler(int newState);
        public event StateChangedHandler StateChanged;

        private int state;
        public int State
        {
            get => state;
            set
            {
                state = value;
                OnStateChanged(state);
            }
        }

        protected virtual void OnStateChanged(int newState)
        {
            StateChanged?.Invoke(newState); // Notify all subscribers
        }
    }
}
