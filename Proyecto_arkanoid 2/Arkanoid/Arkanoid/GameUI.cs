using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

// AUN NO SE HA CAMBIADO A USERCONTROL
namespace Arkanoid
{
    public partial class GameUI : Form
    {
        

        public GameUI()
        {
            InitializeComponent();
            // Expandir la ventana a toda la pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
        }

        
    }
}