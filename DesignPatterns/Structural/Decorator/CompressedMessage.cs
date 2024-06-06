namespace DesignPatterns.Structural.Decorator
{
    public class CompressedMessage : MessageDecorator
    {
        public CompressedMessage(IMessage message) : base(message) { }

        public override string GetContent()
        {
            return Compress(_message.GetContent());
        }

        private string Compress(string content)
        {
            return content.Replace(" ", "");
        }
    }

}
