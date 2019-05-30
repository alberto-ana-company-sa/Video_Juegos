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
    public partial class FiltrosVentas : Form
    {
        public FiltrosVentas()
        {
            InitializeComponent();
        }

        private void btnART_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.VentasTableAdapter taConsIdArticulo = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            tabla = taConsIdArticulo.ConsultaFiltroVentasArticulo(int.Parse(txtArt.Text));

            dgvFiltrosVentas.DataSource = tabla;
        }

        private void btnConsultaFecha_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.VentasTableAdapter taConsFecha = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            tabla = taConsFecha.ConsultarFiltroVentasFecha(txtFecha.Text);

            dgvFiltrosVentas.DataSource = tabla;
           
        }

        private void btnIDCLiente_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.VentasTableAdapter taConsIdCliente = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            tabla = taConsIdCliente.ConsultarFiltroVentasIdCliente(int.Parse(txtIDCLIENTE.Text));

            dgvFiltrosVentas.DataSource = tabla;
        }
    }
}
