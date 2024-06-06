namespace DesignPatterns.Structural.Bridge
{
    public class RedColor : IColor
    {
        public string ApplyColor()
        {
            return "Red";
        }
    }

    public class BlueColor : IColor
    {
        public string ApplyColor()
        {
            return "Blue";
        }
    }

}
