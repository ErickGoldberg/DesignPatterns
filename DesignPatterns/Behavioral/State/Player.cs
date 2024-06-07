namespace DesignPatterns.Behavioral.State
{
    public class Player
    {
        private IPlayerState _state;

        public Player()
        {
            _state = new StoppedState(); 
        }

        public void ChangeState(IPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }

}
