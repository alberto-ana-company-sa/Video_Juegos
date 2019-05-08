namespace Proyecto
{
    partial class Ventas
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
            this.LNomCliente = new System.Windows.Forms.Label();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.LUnidades = new System.Windows.Forms.Label();
            this.LCodigoArticulo = new System.Windows.Forms.Label();
            this.LFVenta = new System.Windows.Forms.Label();
            this.LPlazodePago = new System.Windows.Forms.Label();
            this.LTipodePago = new System.Windows.Forms.Label();
            this.LDescuento = new System.Windows.Forms.Label();
            this.TBNomCLiente = new System.Windows.Forms.TextBox();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            this.TBCodigoArticulo = new System.Windows.Forms.TextBox();
            this.TBPrecioVenta = new System.Windows.Forms.TextBox();
            this.CBTipoPago = new System.Windows.Forms.ComboBox();
            this.NumericPlazoPago = new System.Windows.Forms.NumericUpDown();
            this.NumericUnidades = new System.Windows.Forms.NumericUpDown();
            this.DateFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPlazoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // LNomCliente
            // 
            this.LNomCliente.AutoSize = true;
            this.LNomCliente.Location = new System.Drawing.Point(50, 50);
            this.LNomCliente.Name = "LNomCliente";
            this.LNomCliente.Size = new System.Drawing.Size(130, 17);
            this.LNomCliente.TabIndex = 0;
            this.LNomCliente.Text = "Nombre de CLiente";
            this.LNomCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.Location = new System.Drawing.Point(620, 207);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(109, 17);
            this.LPrecioVenta.TabIndex = 1;
            this.LPrecioVenta.Text = "Precio de Venta";
            // 
            // LUnidades
            // 
            this.LUnidades.AutoSize = true;
            this.LUnidades.Location = new System.Drawing.Point(620, 141);
            this.LUnidades.Name = "LUnidades";
            this.LUnidades.Size = new System.Drawing.Size(68, 17);
            this.LUnidades.TabIndex = 2;
            this.LUnidades.Text = "Unidades";
            // 
            // LCodigoArticulo
            // 
            this.LCodigoArticulo.AutoSize = true;
            this.LCodigoArticulo.Location = new System.Drawing.Point(620, 76);
            this.LCodigoArticulo.Name = "LCodigoArticulo";
            this.LCodigoArticulo.Size = new System.Drawing.Size(123, 17);
            this.LCodigoArticulo.TabIndex = 3;
            this.LCodigoArticulo.Text = "Codigo de Articulo";
            this.LCodigoArticulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // LFVenta
            // 
            this.LFVenta.AutoSize = true;
            this.LFVenta.Location = new System.Drawing.Point(50, 295);
            this.LFVenta.Name = "LFVenta";
            this.LFVenta.Size = new System.Drawing.Size(108, 17);
            this.LFVenta.TabIndex = 4;
            this.LFVenta.Text = "Fecha de Venta";
            // 
            // LPlazodePago
            // 
            this.LPlazodePago.AutoSize = true;
            this.LPlazodePago.Location = new System.Drawing.Point(50, 232);
            this.LPlazodePago.Name = "LPlazodePago";
            this.LPlazodePago.Size = new System.Drawing.Size(100, 17);
            this.LPlazodePago.TabIndex = 5;
            this.LPlazodePago.Text = "Plazo de Pago";
            // 
            // LTipodePago
            // 
            this.LTipodePago.AutoSize = true;
            this.LTipodePago.Location = new System.Drawing.Point(50, 166);
            this.LTipodePago.Name = "LTipodePago";
            this.LTipodePago.Size = new System.Drawing.Size(93, 17);
            this.LTipodePago.TabIndex = 6;
            this.LTipodePago.Text = "Tipo de Pago";
            // 
            // LDescuento
            // 
            this.LDescuento.AutoSize = true;
            this.LDescuento.Location = new System.Drawing.Point(50, 116);
            this.LDescuento.Name = "LDescuento";
            this.LDescuento.Size = new System.Drawing.Size(76, 17);
            this.LDescuento.TabIndex = 7;
            this.LDescuento.Text = "Descuento";
            // 
            // TBNomCLiente
            // 
            this.TBNomCLiente.Location = new System.Drawing.Point(272, 50);
            this.TBNomCLiente.Name = "TBNomCLiente";
            this.TBNomCLiente.Size = new System.Drawing.Size(135, 22);
            this.TBNomCLiente.TabIndex = 8;
            // 
            // TBDescuento
            // 
            this.TBDescuento.Location = new System.Drawing.Point(272, 113);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(135, 22);
            this.TBDescuento.TabIndex = 9;
            // 
            // TBCodigoArticulo
            // 
            this.TBCodigoArticulo.Location = new System.Drawing.Point(781, 71);
            this.TBCodigoArticulo.Name = "TBCodigoArticulo";
            this.TBCodigoArticulo.Size = new System.Drawing.Size(135, 22);
            this.TBCodigoArticulo.TabIndex = 13;
            // 
            // TBPrecioVenta
            // 
            this.TBPrecioVenta.Location = new System.Drawing.Point(781, 207);
            this.TBPrecioVenta.Name = "TBPrecioVenta";
            this.TBPrecioVenta.Size = new System.Drawing.Size(135, 22);
            this.TBPrecioVenta.TabIndex = 15;
            // 
            // CBTipoPago
            // 
            this.CBTipoPago.FormattingEnabled = true;
            this.CBTipoPago.Location = new System.Drawing.Point(272, 157);
            this.CBTipoPago.Name = "CBTipoPago";
            this.CBTipoPago.Size = new System.Drawing.Size(135, 24);
            this.CBTipoPago.TabIndex = 16;
            // 
            // NumericPlazoPago
            // 
            this.NumericPlazoPago.Location = new System.Drawing.Point(272, 232);
            this.NumericPlazoPago.Name = "NumericPlazoPago";
            this.NumericPlazoPago.Size = new System.Drawing.Size(120, 22);
            this.NumericPlazoPago.TabIndex = 17;
            // 
            // NumericUnidades
            // 
            this.NumericUnidades.Location = new System.Drawing.Point(781, 141);
            this.NumericUnidades.Name = "NumericUnidades";
            this.NumericUnidades.Size = new System.Drawing.Size(120, 22);
            this.NumericUnidades.TabIndex = 18;
            // 
            // DateFechaVenta
            // 
            this.DateFechaVenta.Location = new System.Drawing.Point(272, 290);
            this.DateFechaVenta.Name = "DateFechaVenta";
            this.DateFechaVenta.Size = new System.Drawing.Size(274, 22);
            this.DateFechaVenta.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 75);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateFechaVenta);
            this.Controls.Add(this.NumericUnidades);
            this.Controls.Add(this.NumericPlazoPago);
            this.Controls.Add(this.CBTipoPago);
            this.Controls.Add(this.TBPrecioVenta);
            this.Controls.Add(this.TBCodigoArticulo);
            this.Controls.Add(this.TBDescuento);
            this.Controls.Add(this.TBNomCLiente);
            this.Controls.Add(this.LDescuento);
            this.Controls.Add(this.LTipodePago);
            this.Controls.Add(this.LPlazodePago);
            this.Controls.Add(this.LFVenta);
            this.Controls.Add(this.LCodigoArticulo);
            this.Controls.Add(this.LUnidades);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.LNomCliente);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.NumericPlazoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNomCliente;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.Label LUnidades;
        private System.Windows.Forms.Label LCodigoArticulo;
        private System.Windows.Forms.Label LFVenta;
        private System.Windows.Forms.Label LPlazodePago;
        private System.Windows.Forms.Label LTipodePago;
        private System.Windows.Forms.Label LDescuento;
        private System.Windows.Forms.TextBox TBNomCLiente;
        private System.Windows.Forms.TextBox TBDescuento;
        private System.Windows.Forms.TextBox TBCodigoArticulo;
        private System.Windows.Forms.TextBox TBPrecioVenta;
        private System.Windows.Forms.ComboBox CBTipoPago;
        private System.Windows.Forms.NumericUpDown NumericPlazoPago;
        private System.Windows.Forms.NumericUpDown NumericUnidades;
        private System.Windows.Forms.DateTimePicker DateFechaVenta;
        private System.Windows.Forms.Button button1;
    }
}