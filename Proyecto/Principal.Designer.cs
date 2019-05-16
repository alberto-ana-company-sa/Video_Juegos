namespace Proyecto
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.filtrosToolStripMenuItem,
            this.estadísticasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.añadirClienteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem1.Text = "&Ventanas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.ventasToolStripMenuItem1,
            this.stockToolStripMenuItem1});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.filtrosToolStripMenuItem.Text = "&Filtros";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // stockToolStripMenuItem1
            // 
            this.stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            this.stockToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.stockToolStripMenuItem1.Text = "Stock";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.estadísticasToolStripMenuItem.Text = "&Estadísticas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // añadirClienteToolStripMenuItem
            // 
            this.añadirClienteToolStripMenuItem.Name = "añadirClienteToolStripMenuItem";
            this.añadirClienteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.añadirClienteToolStripMenuItem.Text = "Añadir Cliente";
            this.añadirClienteToolStripMenuItem.Click += new System.EventHandler(this.añadirClienteToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Ventana Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirClienteToolStripMenuItem;
    }
}

