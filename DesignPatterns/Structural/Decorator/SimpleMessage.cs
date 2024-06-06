namespace DesignPatterns.Structural.Decorator
{
    public class SimpleMessage : IMessage
    {
        private string _content;

        public SimpleMessage(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }

}
