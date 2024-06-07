namespace DesignPatterns.Behavioral.Mediator
{
    public class ResultMediator
    {
        public ResultMediator()
        {
            IChatMediator mediator = new ChatMediator();

            User user1 = new User(mediator, "Alice");
            User user2 = new User(mediator, "Bob");
            User user3 = new User(mediator, "Charlie");

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.SendMessage("Hello, everyone!");
            user2.SendMessage("Hi, Alice!");
            user3.SendMessage("Hey, Bob!");
        }
    }
}
