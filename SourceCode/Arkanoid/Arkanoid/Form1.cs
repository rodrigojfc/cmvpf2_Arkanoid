using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private ControlGameUI cg;
        
        public Form1()
        {
            InitializeComponent();
            // Extender la ventana en toda la pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cg = new ControlGameUI(cmbPlayer.Text);
            
            cg.Dock = DockStyle.Fill;

            cg.Width = Width;
            cg.Height = Height;

            
            
            // Esconder tablelayout del menu principal y mostrar user control del juego
            tloMain.Hide();
            Controls.Add(cg);
            
            // CODIGO PREVIO
            
            /*DataRowView player1 = (DataRowView) cmbPlayer.SelectedItem;
            DataRow player = (DataRow) player1.Row;
            GameUI Game = new GameUI(player);
            
            Hide();
            Game.Show();*/
            cg.EndGame = () =>
            {
                //cg = null;
                //cg = new ControlGameUI(cmbPlayer.Text);

                MessageBox.Show("Has perdido");

                cg.Hide();
                tloMain.Show();
            };
            
        }

        public void cargarCombo()
        {
            // Mostrar los nombres de los jugadores registrados en el combobox
            
            var sql = "Select * from player";
            try
            {
                var dt = ConnectionBD.ExecuteQuery(sql);
                cmbPlayer.DataSource = null;
                cmbPlayer.ValueMember = "playerid";
                cmbPlayer.DisplayMember = "username";
                cmbPlayer.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Arkanoid", MessageBoxButtons.OK);
            }
        }

        private void btnCreatePlayer_Click_1(object sender, EventArgs e)
        {
            // Esconder form1 y mostrar crear jugador
            GameMenu menu = new GameMenu(1);
            Hide();
            menu.Show();        
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            // Esconder form1 y mostrar puntajes
            GameMenu menu = new GameMenu(2);
            Hide();
            menu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            
            // LANZABA EXCEPCION
            
            //DataRowView player1 = (DataRowView) cmbPlayer.SelectedItem;
            //DataRow player = player1.Row;
            
            /*cg = new ControlGameUI(player);
            
            cg.Dock = DockStyle.Fill;

            cg.Width = Width;
            cg.Height = Height;

            cg.EndGame = () =>
            {
                cg = null;
                cg = new ControlGameUI(cmbPlayer.Text);

                MessageBox.Show("Has perdido");

                cg.Hide();
                tloMain.Show();
            };*/
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}