namespace MyBlazorGame.Data
{
    public class Game1Service
    {

        public Task<Game1> GetGameAsync()
        {
            return Task.FromResult(new Game1
            {
            });
        }
    }
}