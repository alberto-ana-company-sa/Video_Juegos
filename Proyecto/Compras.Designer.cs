namespace Proyecto
{
    partial class Compras
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
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblNombreProv = new System.Windows.Forms.Label();
            this.lblPrecioCoste = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblUni = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipoArt = new System.Windows.Forms.Label();
            this.lblNomArticulo = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPlazoPago = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtNomArt = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.numPlazoPago = new System.Windows.Forms.NumericUpDown();
            this.numUnidades = new System.Windows.Forms.NumericUpDown();
            this.numPrecioCoste = new System.Windows.Forms.NumericUpDown();
            this.txtCaracteristicas = new System.Windows.Forms.TextBox();
            this.cmbTipoArt = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCoste)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Location = new System.Drawing.Point(62, 83);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(101, 13);
            this.lblFechaCompra.TabIndex = 0;
            this.lblFechaCompra.Text = "Fecha de la compra";
            // 
            // lblNombreProv
            // 
            this.lblNombreProv.AutoSize = true;
            this.lblNombreProv.Location = new System.Drawing.Point(62, 115);
            this.lblNombreProv.Name = "lblNombreProv";
            this.lblNombreProv.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProv.TabIndex = 1;
            this.lblNombreProv.Text = "Nombre provincia";
            // 
            // lblPrecioCoste
            // 
            this.lblPrecioCoste.AutoSize = true;
            this.lblPrecioCoste.Location = new System.Drawing.Point(424, 210);
            this.lblPrecioCoste.Name = "lblPrecioCoste";
            this.lblPrecioCoste.Size = new System.Drawing.Size(81, 13);
            this.lblPrecioCoste.TabIndex = 2;
            this.lblPrecioCoste.Text = "Precio de coste";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(424, 244);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(78, 13);
            this.lblCaracteristicas.TabIndex = 3;
            this.lblCaracteristicas.Text = "Características";
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Location = new System.Drawing.Point(424, 179);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(52, 13);
            this.lblUni.TabIndex = 4;
            this.lblUni.Text = "Unidades";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(424, 146);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipoArt
            // 
            this.lblTipoArt.AutoSize = true;
            this.lblTipoArt.Location = new System.Drawing.Point(424, 115);
            this.lblTipoArt.Name = "lblTipoArt";
            this.lblTipoArt.Size = new System.Drawing.Size(84, 13);
            this.lblTipoArt.TabIndex = 6;
            this.lblTipoArt.Text = "Tipo del artículo";
            // 
            // lblNomArticulo
            // 
            this.lblNomArticulo.AutoSize = true;
            this.lblNomArticulo.Location = new System.Drawing.Point(424, 83);
            this.lblNomArticulo.Name = "lblNomArticulo";
            this.lblNomArticulo.Size = new System.Drawing.Size(100, 13);
            this.lblNomArticulo.TabIndex = 7;
            this.lblNomArticulo.Text = "Nombre del artículo";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(62, 210);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 8;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblPlazoPago
            // 
            this.lblPlazoPago.AutoSize = true;
            this.lblPlazoPago.Location = new System.Drawing.Point(62, 179);
            this.lblPlazoPago.Name = "lblPlazoPago";
            this.lblPlazoPago.Size = new System.Drawing.Size(76, 13);
            this.lblPlazoPago.TabIndex = 9;
            this.lblPlazoPago.Text = "Plazo de Pago";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(62, 146);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(71, 13);
            this.lblTipoPago.TabIndex = 10;
            this.lblTipoPago.Text = "Tipo de Pago";
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Location = new System.Drawing.Point(193, 77);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtFechaCompra.TabIndex = 11;
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(193, 108);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(110, 20);
            this.txtNomProv.TabIndex = 12;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(193, 203);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(110, 20);
            this.txtDescuento.TabIndex = 13;
            // 
            // txtNomArt
            // 
            this.txtNomArt.Location = new System.Drawing.Point(564, 80);
            this.txtNomArt.Name = "txtNomArt";
            this.txtNomArt.Size = new System.Drawing.Size(110, 20);
            this.txtNomArt.TabIndex = 14;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(564, 139);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(110, 20);
            this.txtModelo.TabIndex = 15;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(193, 139);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPago.TabIndex = 16;
            // 
            // numPlazoPago
            // 
            this.numPlazoPago.Location = new System.Drawing.Point(193, 177);
            this.numPlazoPago.Name = "numPlazoPago";
            this.numPlazoPago.Size = new System.Drawing.Size(120, 20);
            this.numPlazoPago.TabIndex = 17;
            // 
            // numUnidades
            // 
            this.numUnidades.Location = new System.Drawing.Point(564, 177);
            this.numUnidades.Name = "numUnidades";
            this.numUnidades.Size = new System.Drawing.Size(120, 20);
            this.numUnidades.TabIndex = 18;
            // 
            // numPrecioCoste
            // 
            this.numPrecioCoste.Location = new System.Drawing.Point(564, 208);
            this.numPrecioCoste.Name = "numPrecioCoste";
            this.numPrecioCoste.Size = new System.Drawing.Size(120, 20);
            this.numPrecioCoste.TabIndex = 19;
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.Location = new System.Drawing.Point(564, 241);
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(110, 20);
            this.txtCaracteristicas.TabIndex = 20;
            // 
            // cmbTipoArt
            // 
            this.cmbTipoArt.FormattingEnabled = true;
            this.cmbTipoArt.Location = new System.Drawing.Point(564, 112);
            this.cmbTipoArt.Name = "cmbTipoArt";
            this.cmbTipoArt.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoArt.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 59);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTipoArt);
            this.Controls.Add(this.txtCaracteristicas);
            this.Controls.Add(this.numPrecioCoste);
            this.Controls.Add(this.numUnidades);
            this.Controls.Add(this.numPlazoPago);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNomArt);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtNomProv);
            this.Controls.Add(this.dtFechaCompra);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblPlazoPago);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblNomArticulo);
            this.Controls.Add(this.lblTipoArt);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.lblPrecioCoste);
            this.Controls.Add(this.lblNombreProv);
            this.Controls.Add(this.lblFechaCompra);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.numPlazoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCoste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblNombreProv;
        private System.Windows.Forms.Label lblPrecioCoste;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTipoArt;
        private System.Windows.Forms.Label lblNomArticulo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPlazoPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtNomArt;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.NumericUpDown numPlazoPago;
        private System.Windows.Forms.NumericUpDown numUnidades;
        private System.Windows.Forms.NumericUpDown numPrecioCoste;
        private System.Windows.Forms.TextBox txtCaracteristicas;
        private System.Windows.Forms.ComboBox cmbTipoArt;
        private System.Windows.Forms.Button btnAdd;
    }
}