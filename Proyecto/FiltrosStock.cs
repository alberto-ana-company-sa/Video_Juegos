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
    public partial class FiltrosStock : Form
    {
        public FiltrosStock()
        {
            InitializeComponent();
        }

        private void BtnART_Click(object sender, EventArgs e)
        {
            /* Se mostrará en la rejilla lo que el usuario pondrá en el TextBox, correspondiente a la fecha de pago.
             * Llamamos a un método que va a poseer la consulta, anteriormente creada en el Dataset.xsd, dicha consulta
             * podrá devolver múltiples datos, por lo tanto se tendrá que crear un Objeto que guarde todos esos datos.
             * DataTable tabla = new DataTable(); 
            */
            DataTable tabla = new DataTable();

            /* Creamos el Objeto del tipo de nuestra BBDD y de la tabla donde hemos creado la consulta, por eso el TableAdapter */
            DBaseDeDatosTableAdapters.StockTableAdapter taConsArt = new DBaseDeDatosTableAdapters.StockTableAdapter();

            /* Volcamos en tabla todos los datos devueltos por la consulta, con sus parámetros correspondientes */
            tabla = taConsArt.ConsultaIdArticulo(int.Parse(txtArt.Text));

            /* LLamamos a nuestra rejilla y le damos el valor de nuestra tabla */
            dgvFiltrosStock.DataSource = tabla;
        }

        private void BtnPrecio_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.StockTableAdapter taConsPrecio = new DBaseDeDatosTableAdapters.StockTableAdapter();

            tabla = taConsPrecio.ConsultaPrecioCoste(int.Parse(txtPrecio.Text));

            dgvFiltrosStock.DataSource = tabla;
        }

        private void BtnUnidades_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            DBaseDeDatosTableAdapters.StockTableAdapter taConsUni = new DBaseDeDatosTableAdapters.StockTableAdapter();

            tabla = taConsUni.ConsultaUnidades(int.Parse(txtUnidades.Text));

            dgvFiltrosStock.DataSource = tabla;
        }
    }
}
