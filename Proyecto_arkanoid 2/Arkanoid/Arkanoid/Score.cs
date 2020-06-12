namespace Arkanoid
{
    public class Score
    {
        public int scoreid { get; set; }
        public int score { get; set; }
        public int playerid { get; set; }
        
        public Score()
        {
            scoreid = 0;
            score = 0;
            playerid = 0;
        }
    }
}