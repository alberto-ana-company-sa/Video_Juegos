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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void StockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBaseDeDatos);

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBaseDeDatos.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.dBaseDeDatos.Stock);

        }
    }
}
