namespace DesignPatterns.Structural.Decorator
{
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage _message;

        protected MessageDecorator(IMessage message)
        {
            _message = message;
        }

        public abstract string GetContent();
    }

}
