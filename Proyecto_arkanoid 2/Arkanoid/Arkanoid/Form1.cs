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
            cargarCombo();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameUI Game = new GameUI();
            // Esconder Form1 y mostrar Game
            Hide();
            Game.Show();
            
        }


        public void cargarCombo()
        {
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
            GameMenu menu = new GameMenu();
            Hide();
            menu.Show();        
        }
    }
}