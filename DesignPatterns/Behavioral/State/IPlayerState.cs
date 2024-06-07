namespace DesignPatterns.Behavioral.State
{
    public interface IPlayerState
    {
        void Play(Player player);
        void Pause(Player player);
        void Stop(Player player);
    }

}
