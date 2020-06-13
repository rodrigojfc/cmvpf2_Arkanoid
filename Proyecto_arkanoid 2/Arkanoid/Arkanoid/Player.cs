namespace Arkanoid
{
    public class Player
    {
        public int playerid { get; set; }
        public string username { get; set; }
       
        public Player()
        {
            playerid = 0;
            username = "";
        }
    }
}