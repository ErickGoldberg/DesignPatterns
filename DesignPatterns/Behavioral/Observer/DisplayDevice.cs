namespace DesignPatterns.Behavioral.Observer
{
    public class DisplayDevice : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Display Device: Temperature changed to {temperature}");
        }
    }
}
