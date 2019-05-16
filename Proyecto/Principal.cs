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


        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* solamente se desea abrir una vez la ventana por lo que se necesita averiguar si la ventanas no esta abierta */
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Ventas")
                {
                    estaAbierta = true;
                    break;
                }
            }

            if (!estaAbierta)
            {
                /* se va a abrir la ventana empleados, pero se tiene que abrir como hija de la ventana actual*/
                /* se ha de declarar una variable del tipo de ventana que se desea abrir */
                Ventas vVentas = new Ventas();

                /* Anrtes de abrir la ventana se ha de especificar que esta ventana es hija de la que estamos codificando*/

                vVentas.MdiParent = this;

                /* ahora ya se abre la ventana */

                vVentas.Show();

            }


        }

        private void añadirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* solamente se desea abrir una vez la ventana por lo que se necesita averiguar si la ventanas no esta abierta */
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Clientes")
                {
                    estaAbierta = true;
                    break;
                }
            }

            if (!estaAbierta)
            {
                /* se va a abrir la ventana empleados, pero se tiene que abrir como hija de la ventana actual*/
                /* se ha de declarar una variable del tipo de ventana que se desea abrir */
                Clientes vClientes = new Clientes();

                /* Anrtes de abrir la ventana se ha de especificar que esta ventana es hija de la que estamos codificando*/

                vClientes.MdiParent = this;

                /* ahora ya se abre la ventana */

                vClientes.Show();

            }
        }
    }
}
