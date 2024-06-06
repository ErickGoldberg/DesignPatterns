namespace DesignPatterns.Structural.Facade
{
    public class ResultFacade
    {
        public ResultFacade()
        {
            // Simplificando o processo de realização de um pedido

            OrderFacade orderFacade = new OrderFacade();

            orderFacade.PlaceOrder("Product123", "CreditCardDetails");
            orderFacade.PlaceOrder("Product456", "PayPalDetails");
        }
    }
}
