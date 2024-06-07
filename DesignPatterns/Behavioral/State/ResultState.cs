namespace DesignPatterns.Behavioral.State
{
    internal class ResultState
    {
        public ResultState()
        {
            Player player = new Player();

            player.Play();
            player.Pause();
            player.Stop();
            player.Pause(); // Tentando pausar quando já está parado
            player.Play(); // Tentando tocar quando está parado
            player.Stop();
        }
    }
}
