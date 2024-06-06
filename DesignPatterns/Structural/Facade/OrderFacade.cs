namespace DesignPatterns.Structural.Facade
{
    public class OrderFacade
    {
        private InventoryService _inventoryService;
        private PaymentService _paymentService;
        private ShippingService _shippingService;

        public OrderFacade()
        {
            _inventoryService = new InventoryService();
            _paymentService = new PaymentService();
            _shippingService = new ShippingService();
        }

        public void PlaceOrder(string productId, string paymentDetails)
        {
            Console.WriteLine("Placing order for product: " + productId);

            if (_inventoryService.CheckStock(productId))
            {
                if (_paymentService.ProcessPayment(paymentDetails))
                {
                    _shippingService.ShipProduct(productId);
                    Console.WriteLine("Order placed successfully.");
                }
                else
                {
                    Console.WriteLine("Payment failed.");
                }
            }
            else
            {
                Console.WriteLine("Product out of stock.");
            }
        }
    }

}
