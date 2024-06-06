namespace DesignPatterns.Structural.Proxy
{
    public class ImageProxy : IImage
    {
        private RealImage _realImage;
        private string _fileName;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }

}
