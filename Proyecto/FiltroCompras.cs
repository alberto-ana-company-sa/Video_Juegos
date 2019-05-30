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
    public partial class FiltroCompras : Form
    {
        public FiltroCompras()
        {
            InitializeComponent();
        }

        private void BtnFechaPago_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.ComprasTableAdapter taConsFecha = new DBaseDeDatosTableAdapters.ComprasTableAdapter();
            
            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taConsFecha.ConsultaFechaPago(int.Parse(txtFecha.Text));
            
            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvFilltrosCompras.DataSource = tabla;
        }

        private void BtnFiltroProv_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.ComprasTableAdapter taConsPrv = new DBaseDeDatosTableAdapters.ComprasTableAdapter();

            tabla = taConsPrv.ConsultarProveedor(int.Parse(txtProv.Text));

            dgvFilltrosCompras.DataSource = tabla;
        }

        private void BtnArticulo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.ComprasTableAdapter taConsArt = new DBaseDeDatosTableAdapters.ComprasTableAdapter();

            tabla = taConsArt.ConsultaArticulo(int.Parse(txtArt.Text));

            dgvFilltrosCompras.DataSource = tabla;
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFech_Click(object sender, EventArgs e)
        {

        }
    }
}
