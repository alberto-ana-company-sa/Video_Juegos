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
    public partial class EstadisticasStock : Form
    {
        public EstadisticasStock()
        {
            InitializeComponent();
        }


        private void BtnArt_Click_1(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.StockTableAdapter taEstaStock = new DBaseDeDatosTableAdapters.StockTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taEstaStock.EstadisticasStock(int.Parse(txtArt.Text));

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvEstadisticasStock.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvEstadisticasStock.Columns["IdArticulo"].Visible = false;
            this.dgvEstadisticasStock.Columns["NombreArticulo"].Visible = false;
            this.dgvEstadisticasStock.Columns["Caracteristicas"].Visible = false;
            this.dgvEstadisticasStock.Columns["PrecioCoste"].Visible = false;
            this.dgvEstadisticasStock.Columns["Beneficio"].Visible = false;
            this.dgvEstadisticasStock.Columns["Unidades"].Visible = false;
            this.dgvEstadisticasStock.Columns["TipoArticulo"].Visible = false;
            this.dgvEstadisticasStock.Columns["IdProveedor"].Visible = false;
            this.dgvEstadisticasStock.Columns["Modelo "].Visible = false;


            /* SUM(PrecioCoste) "Suma Precio Coste", AVG(PrecioCoste) "Media Precio Coste", SUM(dbo.Ventas.PrecioVenta) "Suma Precio Ventas", AVG(dbo.Ventas.PrecioVenta) "Media Precio Ventas", 
              */
        }

        private void lblArt_Click(object sender, EventArgs e)
        {

        }

        private void txtArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEstadisticasStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
