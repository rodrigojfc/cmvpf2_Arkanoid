using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
            cargarPuntajes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                MessageBox.Show("No se permiten campos vacios", "Arkanoid", MessageBoxButtons.OK);
            else if(textBox1.Text.Length < 5)
                MessageBox.Show("El usuario debe tener más de 5 caracteres", "Arkanoid", MessageBoxButtons.OK);
            else
            {
                var sql = string.Format("insert into player(username) values('{0}') ", textBox1.Text);

                try
                {
                    Form1 ventana = new Form1();

                    ConnectionBD.ExecuteNonQuery(sql);
                    Hide();
                    ventana.Show();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Arkanoid", MessageBoxButtons.OK);

                }
            }
        }
        
        public void cargarPuntajes()
        {
            var sql = "Select * from score";
            dataGridView1.DataSource = ConnectionBD.ExecuteQuery(sql);
        }
    }
}