using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class ControlGameUI : UserControl
    {
        //bool rp = true;

        private CustomPictureBox[,] cpb;
        private PictureBox ball;
        private Label nombrePlayer;
        private Label playerScore;
        private int score = 0;
        private string player;
        //private DataRow player;
        
        private delegate void BallActions();
        private readonly BallActions BallMoves;
        public Action EndGame;
        
        public ControlGameUI(string player1)
        {
            InitializeComponent();
            player = player1;
            
            BallMoves = RebotarPelota;
            BallMoves += MoverPelota;
        }
        
        private void GameUI_Load(object sender, EventArgs e)
        {
            // Obtener y mostrar la barra de jugador y la bola
            pictureBox1.BackgroundImage = Image.FromFile("../../Img/Player.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Top = Height - pictureBox1.Height - 80;
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);

            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../Img/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);

            Controls.Add(ball);
            
            // Obtener y mostrar labels
            nombrePlayer = new Label();
            nombrePlayer.Location = new Point((Width/2), 0);
            nombrePlayer.Width = Width / 2;
            nombrePlayer.Height = Height / 20;
            nombrePlayer.BackColor = Color.Blue;
            nombrePlayer.Text = "Jugador: ";
            nombrePlayer.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold,
                GraphicsUnit.Point, ((byte) (0)));
            nombrePlayer.TextAlign = ContentAlignment.MiddleLeft;
            nombrePlayer.ForeColor = SystemColors.ButtonHighlight;
            nombrePlayer.BackgroundImageLayout = ImageLayout.Stretch;
            
            Controls.Add(nombrePlayer);
            
            playerScore = new Label();
            playerScore.Location = new Point(1, 0);
            playerScore.Width = Width / 2;
            playerScore.Height = Height / 20;
            playerScore.BackColor = Color.Blue;
            playerScore.Text = "Score: 0";
            playerScore.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold,
                GraphicsUnit.Point, ((byte) (0)));
            playerScore.TextAlign = ContentAlignment.MiddleLeft;
            playerScore.ForeColor = SystemColors.ButtonHighlight;
            playerScore.BackgroundImageLayout = ImageLayout.Stretch;
            
            Controls.Add(playerScore);
            
            nombrePlayer.Text = "Jugador: " + player;

            LoadTiles();
            timer1.Start();
        }

        private void LoadTiles()
        {
            // Metodo para cargar los bloques
            int xAxis = 20;
            int yAxis = 5;

            int pbHeight = (int) (Height * 0.3) / yAxis;
            int pbWidth = (Width - (xAxis - 20)) / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = (i + 1) * pbHeight;

                    // Si el valor de i = 0, entonces colocar ruta de imagen de bloque blindada

                    if (i == 0)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/armored.png");
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        cpb[i, j].Golpes = 2;
                    }
                    else
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/" + GRN() + ".png");
                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    cpb[i, j].Tag = "tileTag";

                    Controls.Add(cpb[i, j]);
                }
            }
        }

        private int GRN()
        {
            return new Random().Next(1, 9);
        }


        private void GameUI_MouseMove(object sender, MouseEventArgs e)
        {
            // If para ver como sera el movimiento de la bola y la barra dependiendo si el juego ha empezado o no
            if (!GameData.juegoIniciado)
            {
                if (e.X < (Width - pictureBox1.Width))
                {
                    pictureBox1.Left = e.X;
                    ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
                }
            }
            else
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!GameData.juegoIniciado)
                return;

            BallMoves?.Invoke();
            
            /*
            if (ball.Bounds.IntersectsWith(x.Bounds))
            {
                x.Golpes--;

                if (cpb[i, j].Golpes == 0)
                {
                    Controls.Remove(cpb[i,j]);
                        
                }

                GameData.dirY = -GameData.dirY;

                return;
            } */
        }


        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                GameData.juegoIniciado = true;
        }


        private void RebotarPelota()
        {
            // Metodo para rebotar la pelota
            //if (rp)
            //{
                //Metodo: al salirse la pelota 
                if (ball.Bottom > Height)
                {
                    //rp = false;

                    timer1.Stop();
                    EndGame?.Invoke();
                    
                    addScores(player);
                    //return;
                }

                if (ball.Top > Height)
                {
                    GameData.dirX = -GameData.dirX;
                    return;
                }

                if (ball.Bottom < 20)
                {
                    GameData.dirX = -GameData.dirX;
                    return;
                }

                if (ball.Left < 0 || ball.Right > Width)
                {
                    GameData.dirX = -GameData.dirX;
                    return;
                }

                if (ball.Bounds.IntersectsWith(pictureBox1.Bounds) || ball.Top < 0)
                {
                    GameData.dirY = -GameData.dirY;
                }

                foreach (CustomPictureBox x in cpb)
                {
                    if (x is Control && x.Tag == "tileTag")
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Golpes--;
                            
                            if (x.Golpes == 0)
                            {
                                score += 5;
                                playerScore.Text = "Score: " + score;
                                Controls.Remove(x);

                                GameData.dirY = -GameData.dirY;

                                return;
                            }
                        }
                    }
                }
            //}
        }

        private void addScores(string p)
        {
            // CODIO PREVIO
            
            //int playerID = Convert.ToInt32(p[0].ToString());
            //var sql = string.Format("insert into score(score, playerid) values({0}, {1})", score, playerID);
            
            //
            
            // Agregar score segun el nombre del jugador
            var sql = string.Format("insert into score(score, playerid) select {0}, pl.playerid from player pl where pl.username = '{1}' ", score, p);
            
            try
            {
                ConnectionBD.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el puntaje", "Arkanoid", MessageBoxButtons.OK);
            }
        }
        private void MoverPelota()
        {
            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
        }
    }
}