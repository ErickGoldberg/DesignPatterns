namespace DesignPatterns.Behavioral.Mediator
{
    public class User
    {
        private IChatMediator _mediator;
        public string Name { get; private set; }

        public User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} received message: {message}");
        }
    }
}
