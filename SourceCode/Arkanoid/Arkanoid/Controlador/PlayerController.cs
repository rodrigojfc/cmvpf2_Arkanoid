namespace Arkanoid
{
    public static class PlayerController
    {
        // Crear jugador en la base de datos
        public static bool CreatePlayer(string username)
        {
            var dt = ConnectionBD.ExecuteQuery($"SELECT * FROM PLAYER WHERE username = '{username}'");

            if(dt.Rows.Count > 0)
                return true;
            else
            {
                ConnectionBD.ExecuteNonQuery("INSERT INTO PLAYER(username) VALUES" +
                                             $"('{username}')");

                return false;
            }
        }

        // Agregar score al jugador cuando ha ganado el juego
        public static void CreateNewScore(string player, int score)
        {
            ConnectionBD.ExecuteNonQuery(string.Format("insert into score(score, playerid) select {0}, pl.playerid from player pl where pl.username = '{1}' ", score, player));
        }
    }
}