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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBaseDeDatos);

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.dBaseDeDatos.Compras);
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.dBaseDeDatos.Stock);
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.dBaseDeDatos.Proveedores);

        }
    }
}
