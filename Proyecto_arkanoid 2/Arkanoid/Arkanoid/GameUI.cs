using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

// AUN NO SE HA CAMBIADO A USERCONTROL
namespace Arkanoid
{
    public partial class GameUI : Form
    {
        private CustomPictureBox [,] cpb;
        private PictureBox ball;
        private int score = 0;
        private DataRow dt;
        public GameUI(DataRow playerData)
        {
            InitializeComponent();
            // Expandir la ventana a toda la pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            dt = playerData;
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            // Obtener y mostrar la barra de jugador y la boda
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
            
            LoadTiles();
            timer1.Start();
        }

        private void LoadTiles()
        {
            
            // Metodo para cargar los bloques
            int xAxis = 20;
            int yAxis = 5;

            int pbHeight = (int)(Height * 0.3) / yAxis;
            int pbWidth = (Width - (xAxis - 20)) / xAxis;

            cpb = new CustomPictureBox[yAxis, xAxis];

            for(int i = 0; i < yAxis; i++)
            {
                for(int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new CustomPictureBox();
                    
                    if(i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;

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

                    Controls.Add(cpb[i,j]);
                }
            }
        }

        private int GRN()
        {
            return new Random().Next(1,9);
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

            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
            
            

            rebotarPelota();
            
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
        
        
        private void rebotarPelota()
        {
            
            // Metodo para rebotar la pelota
            if (ball.Bottom > Height)
            {
                addScores(dt);
                Application.Exit();
            }

            if (ball.Left < 0 || ball.Right > Width)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds) ||  ball.Top < 0)
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
                            Controls.Remove(x);

                            GameData.dirY = -GameData.dirY;

                            return;
                            
                        }
                    }
                }
            }
            
            
            
        }

        private void addScores(DataRow playerData)
        {
            

            int playerID = Convert.ToInt32(playerData[0].ToString());

            var sql = string.Format("insert into score(score, playerid) values({0}, {1})", score, playerID);
            try
            {
                ConnectionBD.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el puntaje", "Arkanoid", MessageBoxButtons.OK);
            }
        }
        
    }
}