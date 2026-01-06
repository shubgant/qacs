using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // The 'Command' abstract class
    public interface ICommand
    {
        void Execute();
    }
}
