namespace DesignPatterns.Behavioral.Observer
{
    public class ResultObserver
    {
        public ResultObserver()
        {
            WeatherStation weatherStation = new WeatherStation();

            DisplayDevice display1 = new DisplayDevice();
            DisplayDevice display2 = new DisplayDevice();

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.SetTemperature(25.5f);
        }
    }
}
