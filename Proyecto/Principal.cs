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

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* EN ESTE PROCEDIMIENTO DE EVENTO SE PONE EL CÓDIGO QUE PERMITE
             * ABRIR LA VENTANA DE CLIENTES, CUANDO SE PULSA EN LA OPCIÓN DE
             * CLIENTES DEL SUBMENU DATOS DEL MENU PRINCIPAL. ES NECESARIO,
             * PARA NUESTRO CASO, ASEGURARSE QUE LA VENTANA SOLO SE ABRA UNA VEZ, NO
             * PUEDE HABER VARIAS VENTANAS IGUALES ABIERTAS EN NUESTRA APLICACIÓN */

            bool estaAbierta = false;

            /* SE VAN A RECORRER TODAS LAS VENTANAS QUE SE ENCUENTREN ABIERTAS
             * DURANTE LA EJECUCIÓN DE NUESTRA APLICACIÓN, CONSULTANDO EL TEXTO
             * DEL TITULO DE LA VENTANA. SI YA ESTA ABIERTA SE PONE UN VALOR EN
             * LA VARIABLE BOOLEANA, PARA NO VOLVER A ABRIR LA MISMA VENTANA */

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Compras")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                /* PARA PODER ABRIR UNA VENTANA, PRIMERO ES NECESARIO 
                 * DECLARAR UNA VARIABLE DEL TIPO DE VENTANA QUE DESEAMOS
                 * ABRIR. DADO QUE LA VENTANA A ABRIR ES HIJA DE LA QUE EN
                 * ESTE MOMENTO ESTAMOS CODIFICANDO (INTERFACE MDI), HEMOS
                 * DE ESPECIFICARLO EN EL CÓDIGO */

                Compras vCompras = new Compras();

                // AQUI ES DONDE SE ESPECIFICA QUE EL PADRE DE LA VENTANA QUE 
                // DESEAMOS ABRIR ES LA VENTANA EN LA QUE ESTAMOS CODIFICANDO

                vCompras.MdiParent = this;
                vCompras.Show();
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;
            
            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Ventas")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                Ventas vVentas = new Ventas();

                vVentas.MdiParent = this;
                vVentas.Show();
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Stock")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                Stock vStock = new Stock();

                vStock.MdiParent = this;
                vStock.Show();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Acerca de...")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                AcercaDe vAcercaDe = new AcercaDe();

                vAcercaDe.MdiParent = this;
                vAcercaDe.Show();
            }
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Ayuda")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                Ayuda vAyuda = new Ayuda();

                vAyuda.MdiParent = this;
                vAyuda.Show();
            }
        }

        private void FiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Esto hay que borrarlo jej
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            /* BOTÓN DE LA BARRA DE HERRAMIENTAS, CUANDO SE PULSE
             * ACCEDERÁ A LAS OPCIONES DEL MENU, EN ESTE CASO A LA
             * OPCIÓN DE COMPRAS.
             * TAMAÑO 46 X 46, GRACIAS A LA OPCIÓN DE AUTOSIZE A 
             * FALSE, TANTO EN EL BOTÓN COMO EN LA BARRA DE HERRAMIENAS
             * LA IMAGEN SE HA PUESTO A TRAVÉS DE LA PROPIEDAD BACKGROUNDIMAGE
             * Y LA PROPIEDAD BACKGROUNDIMAGELAYOUT A CENTER. */

            /* PARA PODER INVOCAR AL EVENTO CLICK DE CUALQUIER COMPONENTE SE PUEDE
            * CONSEGUIR CON EL METODO PERFORMCLICK, DADO QUE EN LA OPCION DEL MENU
            * YA CODIFICAMOS TODO EL PROCESO, CON INVOCARLO AHORA YA ES SUFICIENTE*/

            comprasToolStripMenuItem.PerformClick();

            /* Llamamos a un método (evento) creado anteriormente en el código,
             * hacemos referencia al metodo en el que llamamos a la Ventana 
             * Compras para que se muestre en nuestra Ventana Principal */

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            ventasToolStripMenuItem.PerformClick();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            stockToolStripMenuItem.PerformClick();
        }

        private void ComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "FiltroCompras")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                FiltroCompras vFiltroCompras = new FiltroCompras();

                vFiltroCompras.MdiParent = this;
                vFiltroCompras.Show();
            }
        }

        private void StockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "FiltrosStock")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                FiltrosStock vFiltrosStock = new FiltrosStock();

                vFiltrosStock.MdiParent = this;
                vFiltrosStock.Show();
            }
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "FiltrosVentas")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                FiltrosVentas vFiltrosVentas = new FiltrosVentas();

                vFiltrosVentas.MdiParent = this;
                vFiltrosVentas.Show();
            }
        }
    }
}
