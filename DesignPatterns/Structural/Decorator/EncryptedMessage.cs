namespace DesignPatterns.Structural.Decorator
{
    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage message) : base(message) { }

        public override string GetContent()
        {
            return Encrypt(_message.GetContent());
        }

        private string Encrypt(string content)
        {
            char[] chars = content.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

}
