using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // The 'ConcreteCommand' class to turn off the light
    public class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light) => _light = light;
        public void Execute() => _light.TurnOff();
    }
}
