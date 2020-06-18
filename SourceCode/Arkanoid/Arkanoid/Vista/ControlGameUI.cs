using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class ControlGameUI : UserControl
    {
        // Declaracion de variables y arreglos a utilizar
        private CustomPictureBox[,] cpb;
        private PictureBox ball;
        private Panel scorePanel;
        private Label remainingLifes, scores;

        private int remainingPb = 0;
        
        // Para trabajar con pic + label
        private PictureBox heart;

        // Para trabajar con n pic
        private PictureBox[] hearts;

        // Declaracion de delegate / action
        private delegate void BallActions();
        private BallActions BallMoves;
        public Action EndGame, WinningGame;
        
        public ControlGameUI()
        {
            InitializeComponent();
            
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

        // Metodo para cargar los bloques
        private void LoadTiles()
        {
            // Variables auxiliares para el calculo de tamano de cada cpb
            int xAxis = 20, yAxis = 5;
            remainingPb = xAxis * yAxis;

            int pbHeight = (int) (Height * 0.3) / yAxis;
            int pbWidth = (Width - (xAxis - 20)) / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];

            // Rutina de instanciacion y agregacion al UserControl
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();

                    if (i == 3)
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;

                    // Seteando el tamano
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight + scorePanel.Height + 1;

                    // Si el valor de i = 3, entonces colocar ruta de imagen de bloque blindada
                    if (i == 3)
                    {
                        cpb[i, j].BackgroundImage = Image.FromFile("../../Img/armored.png");
                        cpb[i, j].Tag = "blinded";
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

        // Generando numero random
        private int GRN()
        {
            return new Random().Next(1, 9);
        }
        
        private void GameUI_MouseMove(object sender, MouseEventArgs e)
        {
            // If para ver como sera el movimiento de la bola y la barra cuando el juego no ha iniciado
            if (!GameData.gameStarted)
            {
                if (e.X < (Width - playerPb.Width))
                {
                    playerPb.Left = e.X;
                    ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
                }
            }
            // Manejo de movimiento de barra cuando el juego ya inicio
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
            
            try
            {
                BallMoves?.Invoke();
            }
            catch(OutOfBoundsException ex)
            {
                try
                {
                    GameData.lifes--;
                    GameData.gameStarted = false;
                    timer1.Stop();

                    RepositionElements();
                    UpdateElements();

                    if (GameData.lifes == 0)
                    {
                        throw new NoRemainingLifesException("");
                    }
                }
                catch (NoRemainingLifesException ex2)
                {
                    timer1.Stop();
                    EndGame?.Invoke();
                }
            }
        }

        // Detectar Space para iniciar el juego
        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!GameData.gameStarted)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            GameData.gameStarted = true;
                            timer1.Start();
                            break;
                        default:
                            throw new WrongKeyPressedException("Presione Space para iniciar el juego");
                    }
                }
            }
            catch(WrongKeyPressedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Metodo para rebotar la pelota
        private void BounceBall()
        {
            // Pelota se sale del borde
            if (ball.Bottom > Height)
                throw new OutOfBoundsException("");
            
            // Rebote en la parte superior
            if (ball.Bounds.IntersectsWith(scorePanel.Bounds))
                GameData.dirY = -GameData.dirY;

            // Rebote 
            if (ball.Bottom < 20)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            // Rebote en lado derecho o izquierdo de la ventana
            if (ball.Left < 0 || ball.Right > Width)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            // Rebote con el jugador
            if (ball.Bounds.IntersectsWith(playerPb.Bounds) || ball.Top < 0)
            {
                GameData.dirY = -GameData.dirY;
            }
            
            // Rutina de colisiones con cpb
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (cpb[i, j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i, j].Hits--;

                        if (cpb[i, j].Hits == 0)
                        {
                            GameData.score += 5;
                            scores.Text = "Score: " + GameData.score.ToString();
                            
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;

                            remainingPb--;
                        }
                        else if(cpb[i, j].Tag.Equals("blinded"))
                            cpb[i, j].BackgroundImage = Image.FromFile("../../Img/tb2.png");

                        GameData.dirY = -GameData.dirY;

                        if (remainingPb == 0)
                            WinningGame?.Invoke();

                        return;
                    }
                }
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
            
            #region Label + PictureBox
            // Instanciar pb
            heart = new PictureBox();

            heart.Height = heart.Width = scorePanel.Height;

            heart.Top = 0;
            heart.Left = 20;

            heart.BackgroundImage = Image.FromFile("../../Img/Heart.png");
            heart.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion
            
            #region N cantidad de PictureBox
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
            #endregion
            
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
        
        // Reposicionamiento de elementos luego de perder una vida
        private void RepositionElements()
        {
            playerPb.Left = (Width / 2) - (playerPb.Width / 2);
            ball.Top = playerPb.Top - ball.Height;
            ball.Left = playerPb.Left + (playerPb.Width / 2) - (ball.Width / 2);
        }

        // Actualizacion de elementos luego de perder una vida
        private void UpdateElements()
        {
            remainingLifes.Text = "x " + GameData.lifes.ToString();

            scorePanel.Controls.Remove(hearts[GameData.lifes]);
            hearts[GameData.lifes] = null;
        }
    }
}