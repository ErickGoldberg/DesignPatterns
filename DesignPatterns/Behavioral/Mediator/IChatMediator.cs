namespace DesignPatterns.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(User sender, string message);
    }

}
