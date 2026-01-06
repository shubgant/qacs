namespace WeatherMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherDataSubject weatherData = new WeatherDataSubject();
            CurrentConditionsObserver currentDisplay = new CurrentConditionsObserver(weatherData);

            weatherData.SetMeasurements(27, 65, 1026f);
            weatherData.SetMeasurements(28, 70, 1031f);
        }
    }
}
