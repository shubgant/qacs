using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // The 'Invoker' class
    public class RemoteControl
    {
        private ICommand _onCommand;
        private ICommand _offCommand;
        private ICommand _toggleCommand;
        public RemoteControl(ICommand onCommand, ICommand offCommand, ICommand toggleComand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
            _toggleCommand = toggleComand;
        }

        public void PressOnButton() => _onCommand.Execute();
        public void PressOffButton() => _offCommand.Execute();
        public void PressToggleButton() => _toggleCommand.Execute();
    }
}
