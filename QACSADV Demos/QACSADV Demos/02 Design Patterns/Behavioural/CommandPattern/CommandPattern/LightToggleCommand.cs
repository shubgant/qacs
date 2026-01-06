using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // The 'ConcreteCommand' class to turn toggle the light
    public class LightToggleCommand : ICommand
    {
        private Light _light;

        public LightToggleCommand(Light light) => _light = light;

        public void Execute()
        {
            if (_light.Status == LightStatus.Off)
                _light.TurnOn();
            else
                _light.TurnOff();
        }
    }
}
