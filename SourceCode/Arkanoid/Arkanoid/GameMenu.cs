using System;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameMenu : Form
    {
        public delegate void OnClosedWindow();
        public OnClosedWindow CloseAction;
        public GameMenu(int choice)
        { 
           InitializeComponent();
           LoadControls(choice);
           // Expandir ventana a toda la pantalla
           Height = ClientSize.Height;
           Width = ClientSize.Width;
           WindowState = FormWindowState.Maximized;
        }
        
        protected override CreateParams CreateParams
        {
            // Metodo para evitar el blink
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void btnPlayerCreated_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo jugador a la base de datos
            if (txtNewPlayer.Text.Equals(""))
                MessageBox.Show("No se permiten campos vacios", "Arkanoid", MessageBoxButtons.OK);
            else if(txtNewPlayer.Text.Length < 5)
                MessageBox.Show("El usuario debe tener más de 5 caracteres", "Arkanoid", MessageBoxButtons.OK);
            else
            {
                var sql = string.Format("insert into player(username) values('{0}') ", txtNewPlayer.Text);

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
        
        public void ShowScore()
        {
            //Mostrar los top 10 puntajes en el dataGrid
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

        private void btnBackToMain2_Click(object sender, EventArgs e)
        {
            // Esconder GameMenu y mostrar form1
            Form1 ventana = new Form1();
            
            Hide();
            ventana.Show();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            // Esconder GameMenu y mostrar form1
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