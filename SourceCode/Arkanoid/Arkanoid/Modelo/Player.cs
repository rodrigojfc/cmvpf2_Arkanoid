namespace Arkanoid
{
    public class Player
    {
        public string Username { get; set; }
        public int Score { get; set; }

        public Player(string username, int score)
        {
            Username = username;
            Score = score;
        }
    }
}