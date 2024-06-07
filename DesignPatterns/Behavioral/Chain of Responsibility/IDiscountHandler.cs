namespace DesignPatterns.Behavioral.Chain_of_Responsibility
{
    public interface IDiscountHandler
    {
        void SetNext(IDiscountHandler nextHandler);
        double ApplyDiscount(double amount);
    }

}
