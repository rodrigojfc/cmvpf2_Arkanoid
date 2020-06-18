using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private ControlGameUI cg;
        private Player currentPlayer;
        public Form1()
        {
            InitializeComponent();
            
            // Extender la ventana en toda la pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        // Metodo para evitar el blink
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        // Iniciar el juego
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            GameData.InitializeGame();
            
            // Instanciacion y preparacion de UserControl
            cg = new ControlGameUI()
            {
                Dock = DockStyle.Fill,

                Width = Width,
                Height = Height
            };

            currentPlayer = new Player(CmbPlayer.Text, 0);
            
            // Seteo de Delegate que maneja el fin del juego
            cg.EndGame = () =>
            {
                MessageBox.Show("Has perdido " + currentPlayer.Username);

                cg.Hide();
                tloMain.Show();
            };

            // Seteo de Delegate que maneja cuando se gana el juego
            cg.WinningGame = () =>
            {
                PlayerController.CreateNewScore(currentPlayer.Username, GameData.score);

                MessageBox.Show("Has ganado " + currentPlayer.Username + "!");

                cg.Hide();
                tloMain.Show();
            };

            // Esconder tablelayout del menu principal y mostrar user control del juego
            tloMain.Hide();
            Controls.Add(cg);

        }

        // Mostrar los nombres de los jugadores registrados en el combobox
        public void LoadCmbInfo()
        {
            var sql = "Select * from player";
            
            try
            {
                var dt = ConnectionBD.ExecuteQuery(sql);
                CmbPlayer.DataSource = null;
                CmbPlayer.ValueMember = "playerid";
                CmbPlayer.DisplayMember = "username";
                CmbPlayer.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Arkanoid", MessageBoxButtons.OK);
            }
        }

        // Boton para crear un nuevo jugador
        private void BtnCreatePlayer_Click_1(object sender, EventArgs e)
        {
            // Instanciacion de crear jugador en GameMenu
            GameMenu menu = new GameMenu(1);
            
            menu.gn = (string user) => 
            {
                if (PlayerController.CreatePlayer(user))
                {
                    MessageBox.Show($"El username {user} ya existe, por favor utilice uno diferente");
                    return;
                }
                else
                    MessageBox.Show($"Gracias por registrarte {user}!");
                
                currentPlayer = new Player(user, 0);
            };
            
            menu.CloseAction = () =>
            {
                Show();
            };

            // Esconder form1 y mostrar crear jugador
            menu.Show();
            Hide();     
        }
        
        // Boton para ver el top 10
        private void BtnViewScores_Click(object sender, EventArgs e)
        {
            // Instanciacion de ver puntajes en GameMenu
            GameMenu menu = new GameMenu(2);
            
            menu.CloseAction = () =>
            {
                Show();
            };

            // Esconder form1 y mostrar puntajes
            menu.Show();
            Hide();
        }

        // Cargar los usuarios en el combobox al cargar form1
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCmbInfo();
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}