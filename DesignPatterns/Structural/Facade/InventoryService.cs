namespace DesignPatterns.Structural.Facade
{
    public class InventoryService
    {
        public bool CheckStock(string productId)
        {
            Console.WriteLine("Checking stock for product: " + productId);
            return true; 
        }
    }
}
