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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBaseDeDatos);

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.dBaseDeDatos.Stock);
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.dBaseDeDatos.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dBaseDeDatos.Clientes);

        }
    }
}
