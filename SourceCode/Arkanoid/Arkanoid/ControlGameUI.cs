using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class ControlGameUI : UserControl
    {
        
        private CustomPictureBox[,] cpb;
        private PictureBox ball;

        private Panel scorePanel;
        private Label remainingLifes;
        private Label scores;

        // Para trabajar con pic + label
        private PictureBox heart;

        // Para trabajar con n pic
        private PictureBox[] hearts;
        
        private string player;
        private delegate void BallActions();
        private BallActions BallMoves;
        public Action EndGame;
        
        public ControlGameUI(string player1)
        {
            InitializeComponent();
            player = player1;
            
            BallMoves = BounceBall;
            BallMoves += MoveBall;
        }
        
        private void GameUI_Load(object sender, EventArgs e)
        {
            ScoresPanel();
            
            // Obtener y mostrar la barra de jugador y la bola
            playerPb.BackgroundImage = Image.FromFile("../../Img/Player.png");
            playerPb.BackgroundImageLayout = ImageLayout.Stretch;

            playerPb.Top = Height - playerPb.Height - 80;
            playerPb.Left = (Width / 2) - (playerPb.Width / 2);

            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../Img/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = playerPb.Top - ball.Height;
            ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);

            Controls.Add(ball);

            LoadTiles();
        }

        private void LoadTiles()
        {
            // Metodo para cargar los bloques
            int xAxis = 20, yAxis = 5;

            int pbHeight = (int) (Height * 0.3) / yAxis;
            int pbWidth = (Width - (xAxis - 20)) / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 3)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    // Seteando el tamano
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight + scorePanel.Height + 1;

                    int imageBack = 0;

                    if (i % 2 == 0 && j % 2 == 0)
                        imageBack = 3;
                    else if (i % 2 == 0 && j % 2 != 0)
                        imageBack = 4;
                    else if (i % 2 != 0 && j % 2 == 0)
                        imageBack = 4;
                    else
                        imageBack = 3;
                    
                    // Si el valor de i = 3, entonces colocar ruta de imagen de bloque blindada
                    if (i == 3)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/armored.png");
                        cpb[i, j].Tag = "blinded";
                        
                        //cpb[i, j].Golpes = 2;
                    }
                    else
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/" + GRN() + ".png");
                        cpb[i, j].Tag = "tileTag";
                    }

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

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
            if (!GameData.gameStarted)
            {
                if (e.X < (Width - playerPb.Width))
                {
                    playerPb.Left = e.X;
                    ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
                }
            }
            else
            {
                if (e.X < (Width - playerPb.Width))
                    playerPb.Left = e.X;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!GameData.gameStarted)
                return;

            BallMoves?.Invoke();
        }

        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GameData.gameStarted = true;
                timer1.Start();
            }
        }

        private void BounceBall()
        {
            // Metodo para rebotar la pelota
            if (ball.Top < 0)
                GameData.dirY = -GameData.dirY;
            
            if (ball.Bottom > Height)
            {
                GameData.lifes--;
                GameData.gameStarted = false;
                timer1.Stop();
                
                RepositionElements();
                UpdateElements();

                if (GameData.lifes == 0)
                {
                    timer1.Stop();
                    EndGame?.Invoke();
                }

                AddScores(player);
                //return;
            }

            if (ball.Bounds.IntersectsWith(scorePanel.Bounds))
            {
                GameData.dirY = -GameData.dirY;
                
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

            if (ball.Bounds.IntersectsWith(playerPb.Bounds) || ball.Top < 0)
            {
                GameData.dirY = -GameData.dirY;
            }
            
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (cpb[i, j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i, j].Golpes--;

                        if (cpb[i, j].Golpes == 0)
                        {
                            GameData.score += 5;
                            scores.Text = "Score: " + GameData.score.ToString();
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;
                        }
                        else if(cpb[i, j].Tag.Equals("blinded"))
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Img/tb2.png");

                        GameData.dirY = -GameData.dirY;
                        

                        return;
                    }
                }
            }
            
            // OPTION 2
            /*foreach (CustomPictureBox x in cpb)
            {
                
                if (ball.Bounds.IntersectsWith(x.Bounds))
                {
                    x.Golpes--;
                
                    if (x.Golpes == 0 && x.Tag.Equals("tiletag"))
                    {
                        GameData.score += 5;
                        scores.Text = "Score: " + GameData.score.ToString();
                        Controls.Remove(x);
                        
                    }
                    else if (x.Tag.Equals("blinded"))
                    {
                        if (x.Golpes == 0)
                        {
                            GameData.score += 5;
                            scores.Text = "Score: " + GameData.score.ToString();
                            Controls.Remove(x);
                        }
                        else
                        {
                            x.BackgroundImage = Image.FromFile("../../Img/tb2.png");
                            x.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }

                    GameData.dirY = -GameData.dirY;

                    return;
                }
            }*/
            
            // PREVIOUS OG FOREACH
            /*foreach (CustomPictureBox x in cpb)
            {
                if (x is Control && x.Tag == "tileTag")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Golpes--;
                        
                        if (x.Golpes == 0)
                        {
                            GameData.score += 5;
                            scores.Text = "Score: " + GameData.score;
                            Controls.Remove(x);

                            GameData.dirY = -GameData.dirY;

                            return;
                        }
                    }
                }
            }*/
            
        }

        private void AddScores(string p)
        {
            // Agregar score segun el nombre del jugador
            var sql = string.Format("insert into score(score, playerid) select {0}, pl.playerid from player pl where pl.username = '{1}' ", GameData.score, p);
            
            try
            {
                ConnectionBD.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el puntaje", "Arkanoid", MessageBoxButtons.OK);
            }
        }
        
        private void MoveBall()
        {
            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
        }
        
         // Se encarga de inicializar todos los elementos del panel de puntajes + vidas
        private void ScoresPanel()
        {
            // Instanciar panel
            scorePanel = new Panel();

            // Setear elementos del panel
            scorePanel.Width = Width;
            scorePanel.Height = (int)(Height * 0.07);

            scorePanel.Top = scorePanel.Left = 0;

            scorePanel.BackColor = Color.Black;
            
            // Instanciar pb
            heart = new PictureBox();

            heart.Height = heart.Width = scorePanel.Height;

            heart.Top = 0;
            heart.Left = 20;

            heart.BackgroundImage = Image.FromFile("../../Img/Heart.png");
            heart.BackgroundImageLayout = ImageLayout.Stretch;

            hearts = new PictureBox[GameData.lifes];

            for(int i = 0; i < GameData.lifes; i++)
            {
                // Instanciacion de pb
                hearts[i] = new PictureBox();

                hearts[i].Height = hearts[i].Width = scorePanel.Height;

                hearts[i].BackgroundImage = Image.FromFile("../../Img/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;

                hearts[i].Top = 0;

                if (i == 0)
                    // corazones[i].Left = 20;
                    hearts[i].Left = scorePanel.Width / 2;
                else
                {
                    hearts[i].Left = hearts[i - 1].Right + 5;
                }
            }

            // Instanciar labels
            remainingLifes = new Label();
            scores = new Label();

            // Setear elementos de los labels
            remainingLifes.ForeColor = scores.ForeColor = Color.White;

            remainingLifes.Text = "x " + GameData.lifes.ToString();
            scores.Text = "Score: " + GameData.score.ToString();

            remainingLifes.Font = scores.Font = new Font("Microsoft YaHei", 16F);
            remainingLifes.TextAlign = scores.TextAlign = ContentAlignment.MiddleCenter;

            remainingLifes.Left = heart.Right + 5;
            scores.Left = Width - 200;

            remainingLifes.Height = scores.Height = scorePanel.Height;

            scorePanel.Controls.Add(heart);
            scorePanel.Controls.Add(remainingLifes);
            scorePanel.Controls.Add(scores);

            foreach(var pb in hearts)
            {
                scorePanel.Controls.Add(pb);
            }

            Controls.Add(scorePanel);
        }
        
        private void RepositionElements()
        {
            playerPb.Left = (Width / 2) - (playerPb.Width / 2);
            ball.Top = playerPb.Top - ball.Height;
            ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
        }

        private void UpdateElements()
        {
            remainingLifes.Text = "x " + GameData.lifes.ToString();

            scorePanel.Controls.Remove(hearts[GameData.lifes]);
            hearts[GameData.lifes] = null;
        }
    }
}