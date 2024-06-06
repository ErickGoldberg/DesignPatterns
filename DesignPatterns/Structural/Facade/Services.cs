namespace DesignPatterns.Structural.Facade
{
    public class PaymentService
    {
        public bool ProcessPayment(string paymentDetails)
        {
            Console.WriteLine("Processing payment with details: " + paymentDetails);
            return true; 
        }
    }

    public class ShippingService
    {
        public void ShipProduct(string productId)
        {
            Console.WriteLine("Shipping product: " + productId);
        }
    }
}
