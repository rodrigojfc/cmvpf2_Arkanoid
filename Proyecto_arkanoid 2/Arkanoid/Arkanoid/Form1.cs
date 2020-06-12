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
            DataRowView player1 = (DataRowView) comboBox1.SelectedItem;
            DataRow player = (DataRow) player1.Row;
            GameUI Game = new GameUI(player);
            // Esconder Form1 y mostrar Game
            Hide();
            Game.Show();
            
        }


        public void cargarCombo()
        {
            // Mostrar los nombres de los jugadores registrados en el combobox
            var sql = "Select * from player";
            try
            {
                var dt = ConnectionBD.ExecuteQuery(sql);
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "playerid";
                comboBox1.DisplayMember = "username";
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Arkanoid", MessageBoxButtons.OK);
            }

            
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            // Esconder form1 y mostrar crear jugador
            GameMenu menu = new GameMenu(1);
            Hide();
            menu.Show();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esconder form1 y mostrar puntajes
            GameMenu menu = new GameMenu(2);
            Hide();
            menu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }
    }
}