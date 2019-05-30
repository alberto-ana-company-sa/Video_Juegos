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
    public partial class EstadisticasCompras : Form
    {
        public EstadisticasCompras()
        {
            InitializeComponent();
        }

        private void BtnProv_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.ComprasTableAdapter taEstaCompras = new DBaseDeDatosTableAdapters.ComprasTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taEstaCompras.EstadisticasProv(int.Parse(txtPrv.Text));

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvCompras.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvCompras.Columns["IdCompras"].Visible = false;
            this.dgvCompras.Columns["FechaPago"].Visible = false;
            this.dgvCompras.Columns["TipoPago"].Visible = false;
            this.dgvCompras.Columns["PlazoPago"].Visible = false;
            this.dgvCompras.Columns["Descuento"].Visible = false;
            this.dgvCompras.Columns["IdArticulo"].Visible = false;
            this.dgvCompras.Columns["IdProveedor"].Visible = false;
        }

        private void BtnFech_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.ComprasTableAdapter taEstaFecha = new DBaseDeDatosTableAdapters.ComprasTableAdapter();

            tabla = taEstaFecha.EstadisticaFech(int.Parse(txtFech.Text));

            dgvCompras.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvCompras.Columns["IdCompras"].Visible = false;
            this.dgvCompras.Columns["FechaPago"].Visible = false;
            this.dgvCompras.Columns["TipoPago"].Visible = false;
            this.dgvCompras.Columns["PlazoPago"].Visible = false;
            this.dgvCompras.Columns["Descuento"].Visible = false;
            this.dgvCompras.Columns["IdArticulo"].Visible = false;
            this.dgvCompras.Columns["IdProveedor"].Visible = false;
        }

        private void BtnArt_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.ComprasTableAdapter taEstaArt = new DBaseDeDatosTableAdapters.ComprasTableAdapter();

            tabla = taEstaArt.EstadisticaArt(int.Parse(txtArt.Text));

            dgvCompras.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvCompras.Columns["IdCompras"].Visible = false;
            this.dgvCompras.Columns["FechaPago"].Visible = false;
            this.dgvCompras.Columns["TipoPago"].Visible = false;
            this.dgvCompras.Columns["PlazoPago"].Visible = false;
            this.dgvCompras.Columns["Descuento"].Visible = false;
            this.dgvCompras.Columns["IdArticulo"].Visible = false;
            this.dgvCompras.Columns["IdProveedor"].Visible = false;
        }

        private void TxtArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void TxtFech_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblArt_Click(object sender, EventArgs e)
        {

        }

        private void LblpRV_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
