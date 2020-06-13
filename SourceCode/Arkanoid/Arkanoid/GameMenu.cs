﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class GameMenu : Form
    {
        public GameMenu(int choice)
        { 
           InitializeComponent();
           loadControls(choice);
           // Expandir ventana a toda la pantalla
           Height = ClientSize.Height;
           Width = ClientSize.Width;
           WindowState = FormWindowState.Maximized;

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
        
        public void cargarPuntajes()
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

        public void loadControls(int num)
        {
            // Mostrar la tab dependiendo de la decision en form1
            if (num == 2)
            {
                tabControl1.TabPages.Remove(tabPage1);
                cargarPuntajes();
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
            
                
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
    }
}