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
    public partial class EstadisticasVentas : Form
    {
        public EstadisticasVentas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bCliente_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.VentasTableAdapter taEstaVentas = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taEstaVentas.EstadisticaCliente(int.Parse(TBCLIENTE.Text));

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvEstadisticasvENTAS.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvEstadisticasvENTAS.Columns["IdVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["FechaVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdCliente"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["TipoPago"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Descuento"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdArticulo"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Unidades"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PrecioVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PlazoPago"].Visible = false;
        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.VentasTableAdapter taEstaVentas = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taEstaVentas.EstadisticaArticulo(int.Parse(txtArt.Text));

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvEstadisticasvENTAS.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvEstadisticasvENTAS.Columns["IdVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["FechaVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdCliente"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["TipoPago"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Descuento"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdArticulo"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Unidades"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PrecioVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PlazoPago"].Visible = false;
        }

        private void BFECHA_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
            * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
            * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
            * DataTable tabla = new DataTable(); 
           */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.VentasTableAdapter taEstaVentas = new DBaseDeDatosTableAdapters.VentasTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taEstaVentas.EstadisticaFecha(TBFECHA.Text);

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvEstadisticasvENTAS.DataSource = tabla;

            /* PARA OCULTAR LAS COLUMNAS QUE NO QUEREMOS HACEMOS ESTO: 
             * NOMBRE DEL DATAGRIDVIEW = dgvCompras */
            this.dgvEstadisticasvENTAS.Columns["IdVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["FechaVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdCliente"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["TipoPago"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Descuento"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["IdArticulo"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["Unidades"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PrecioVenta"].Visible = false;
            this.dgvEstadisticasvENTAS.Columns["PlazoPago"].Visible = false;
        }
    }
}
