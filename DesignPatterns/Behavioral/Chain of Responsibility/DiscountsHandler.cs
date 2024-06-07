namespace DesignPatterns.Behavioral.Chain_of_Responsibility
{
    public class SeniorDiscountHandler : IDiscountHandler
    {
        private IDiscountHandler _nextHandler;

        public void SetNext(IDiscountHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public double ApplyDiscount(double amount)
        {
            if (amount > 100)
            {
                Console.WriteLine("Applying senior discount...");
                return amount * 0.9;
            }
            else if (_nextHandler != null)
            {
                return _nextHandler.ApplyDiscount(amount);
            }
            else
            {
                return amount;
            }
        }
    }

    public class MemberDiscountHandler : IDiscountHandler
    {
        private IDiscountHandler _nextHandler;

        public void SetNext(IDiscountHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public double ApplyDiscount(double amount)
        {
            if (amount > 50)
            {
                Console.WriteLine("Applying member discount...");
                return amount * 0.95; // 5% de desconto para membros
            }
            else if (_nextHandler != null)
            {
                return _nextHandler.ApplyDiscount(amount);
            }
            else
            {
                return amount;
            }
        }
    }

    public class DefaultDiscountHandler : IDiscountHandler
    {
        public void SetNext(IDiscountHandler nextHandler)
        {
            // Ignore
        }

        public double ApplyDiscount(double amount)
        {
            Console.WriteLine("No discount applied.");
            return amount;
        }
    }

}
