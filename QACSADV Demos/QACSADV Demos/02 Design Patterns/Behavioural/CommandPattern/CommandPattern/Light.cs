using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // The 'Receiver' class
    public class Light
    {
        public LightStatus Status { get; set; } = LightStatus.Off;
        public void TurnOn()
        {
            if (Status == LightStatus.Off) { 
                Status = LightStatus.On;
                Console.WriteLine("The light is on");
            }
        }

        public void TurnOff()
        {
            if (Status == LightStatus.On)
            {
                Status = LightStatus.Off;
                Console.WriteLine("The light is off");
            }
        }
    }
}
