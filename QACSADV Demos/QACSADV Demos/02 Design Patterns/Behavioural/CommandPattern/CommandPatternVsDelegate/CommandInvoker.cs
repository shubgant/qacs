using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternVsDelegate
{
    internal class CommandInvoker
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command) => commands.Add(command);

        public void ExecuteAll()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
