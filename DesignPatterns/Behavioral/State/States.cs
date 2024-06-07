namespace DesignPatterns.Behavioral.State
{
    public class PlayingState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Pausing...");
            player.ChangeState(new PausedState());
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Stopping...");
            player.ChangeState(new StoppedState());
        }
    }

    public class PausedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Resuming playback...");
            player.ChangeState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Stopping...");
            player.ChangeState(new StoppedState());
        }
    }

    public class StoppedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Starting playback...");
            player.ChangeState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Player is not playing.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Already stopped.");
        }
    }

}
