namespace Proyecto
{
    partial class FiltroCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroCompras));
            this.btnFechaPago = new System.Windows.Forms.Button();
            this.dgvFilltrosCompras = new System.Windows.Forms.DataGridView();
            this.btnFiltroProv = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.lblFech = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilltrosCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechaPago
            // 
            this.btnFechaPago.Location = new System.Drawing.Point(70, 381);
            this.btnFechaPago.Name = "btnFechaPago";
            this.btnFechaPago.Size = new System.Drawing.Size(148, 53);
            this.btnFechaPago.TabIndex = 0;
            this.btnFechaPago.Text = "CONSULTAR POR FECHA";
            this.btnFechaPago.UseVisualStyleBackColor = true;
            this.btnFechaPago.Click += new System.EventHandler(this.BtnFechaPago_Click);
            // 
            // dgvFilltrosCompras
            // 
            this.dgvFilltrosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilltrosCompras.Location = new System.Drawing.Point(3, 19);
            this.dgvFilltrosCompras.Name = "dgvFilltrosCompras";
            this.dgvFilltrosCompras.Size = new System.Drawing.Size(710, 183);
            this.dgvFilltrosCompras.TabIndex = 1;
            // 
            // btnFiltroProv
            // 
            this.btnFiltroProv.Location = new System.Drawing.Point(493, 381);
            this.btnFiltroProv.Name = "btnFiltroProv";
            this.btnFiltroProv.Size = new System.Drawing.Size(148, 53);
            this.btnFiltroProv.TabIndex = 2;
            this.btnFiltroProv.Text = "CONSULTAR POR PROVEEDOR";
            this.btnFiltroProv.UseVisualStyleBackColor = true;
            this.btnFiltroProv.Click += new System.EventHandler(this.BtnFiltroProv_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(904, 381);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(148, 53);
            this.btnArticulo.TabIndex = 3;
            this.btnArticulo.Text = "CONSULTAR ARTÍCULO";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.BtnArticulo_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(59, 321);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(180, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(479, 321);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(180, 20);
            this.txtProv.TabIndex = 5;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(888, 321);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(180, 20);
            this.txtArt.TabIndex = 6;
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFech.Location = new System.Drawing.Point(67, 276);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(167, 13);
            this.lblFech.TabIndex = 7;
            this.lblFech.Text = "INTRODUZCA FECHA DE PAGO";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProv.Location = new System.Drawing.Point(490, 276);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(149, 13);
            this.lblProv.TabIndex = 8;
            this.lblProv.Text = "INTRODUZCA PROVEEDOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(906, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "INTRODUZCA ARTÍCULO";
            // 
            // FiltroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblFech);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.btnFiltroProv);
            this.Controls.Add(this.dgvFilltrosCompras);
            this.Controls.Add(this.btnFechaPago);
            this.Name = "FiltroCompras";
            this.Text = "FiltroCompras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilltrosCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechaPago;
        private System.Windows.Forms.DataGridView dgvFilltrosCompras;
        private System.Windows.Forms.Button btnFiltroProv;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label lblFech;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label label1;
    }
}