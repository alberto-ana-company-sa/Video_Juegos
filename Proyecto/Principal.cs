using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsFecha.Text = DateTime.Today.ToLongDateString();
            tsHora.Text = DateTime.Now.ToLongTimeString();
        }
        /* hola amigos*/
    }
}
