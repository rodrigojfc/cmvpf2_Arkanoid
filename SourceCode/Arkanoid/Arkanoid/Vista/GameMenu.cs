using System;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameMenu : Form
    {
        // Declaracion de delegates
        public delegate void OnClosedWindow();
        public OnClosedWindow CloseAction;
        
        public delegate void GetUsername(string text);
        public GetUsername gn;
        
        public GameMenu(int choice)
        { 
           InitializeComponent();
           LoadControls(choice);
           
           // Expandir ventana a toda la pantalla
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

        // Agregar un nuevo jugador a la base de datos
        private void btnPlayerCreated_Click(object sender, EventArgs e)
        {
            // Verificaciones para el username
            try
            {
                switch (txtNewPlayer.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("No se puede introducir un nick de mas de 15 car");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyUsernameException("No puede dejar campos vacios");
                    default:
                        gn?.Invoke(txtNewPlayer.Text);
                        break;
                }
            }
            catch(EmptyUsernameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Mostrar los top 10 puntajes en el dataGrid
        public void ShowScore()
        {
            DataTable sql = null;

            try
            {
                sql = ConnectionBD.ExecuteQuery("select pl.username, sc.score " +
                                                "from player pl, score sc " +
                                                "where sc.playerid = pl.playerid order by sc.score desc limit 10");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sql;
        }

        public void LoadControls(int num)
        {
            // Mostrar la tab dependiendo de la decision en form1
            if (num == 2)
            {
                tabControl1.TabPages.Remove(tabPage1);
                ShowScore();
            }
            else
                tabControl1.TabPages.Remove(tabPage2);
        }

        // Esconder GameMenu y mostrar form1
        private void btnBackToMain2_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            
            Hide();
            ventana.Show();
        }

        // Esconder GameMenu y mostrar form1
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            
            Hide();
            ventana.Show();
        }

        private void GameMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAction?.Invoke();
        }
    }
}