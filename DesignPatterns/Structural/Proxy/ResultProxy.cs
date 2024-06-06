namespace DesignPatterns.Structural.Proxy
{
    public class ResultProxy
    {
        public ResultProxy()
        {
            IImage image1 = new ImageProxy("Image1.jpg");
            IImage image2 = new ImageProxy("Image2.jpg");

            // A imagem será carregada e exibida somente quando necessário
            image1.Display(); 
            image1.Display(); // Exibe a image sem recarregar

            image2.Display(); 
            image2.Display(); // Exibe a image sem recarregar
        }
    }
}
