using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

// SE CAMBIÓ A USERCONTROL 
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