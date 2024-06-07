namespace DesignPatterns.Behavioral.Chain_of_Responsibility
{
    public class ResultChainOfResponsability
    {
        public ResultChainOfResponsability()
        {
            var seniorDiscountHandler = new SeniorDiscountHandler();
            var memberDiscountHandler = new MemberDiscountHandler();
            var defaultDiscountHandler = new DefaultDiscountHandler();

            memberDiscountHandler.SetNext(defaultDiscountHandler);
            seniorDiscountHandler.SetNext(memberDiscountHandler);
        }
    }
}
