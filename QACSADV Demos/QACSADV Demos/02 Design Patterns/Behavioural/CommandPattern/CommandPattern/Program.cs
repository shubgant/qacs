namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light); 
            ICommand lightToggle = new LightToggleCommand(light);

            RemoteControl control = new RemoteControl(lightOn, lightOff, lightToggle);
            control.PressOnButton();   // Output: The light is on
            control.PressOffButton();  // Output: The light is off
            control.PressToggleButton();  // Output: The light is on
            control.PressToggleButton();  // Output: The light is off

            control.PressOffButton();  // Output: NO OUTPUT
            control.PressOnButton();   // Output: The light is on
            control.PressOnButton();   // Output: NO OUTPUT

        }
    }
}
