namespace Proyecto
{
    partial class EstadisticasCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadisticasCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lblpRV = new System.Windows.Forms.Label();
            this.txtPrv = new System.Windows.Forms.TextBox();
            this.btnProv = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFech = new System.Windows.Forms.TextBox();
            this.btnFech = new System.Windows.Forms.Button();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnArt = new System.Windows.Forms.Button();
            this.dBaseDeDatos1 = new Proyecto.DBaseDeDatos();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBaseDeDatos1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(383, 37);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(491, 221);
            this.dgvCompras.TabIndex = 0;
            // 
            // lblpRV
            // 
            this.lblpRV.AutoSize = true;
            this.lblpRV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblpRV.Location = new System.Drawing.Point(102, 343);
            this.lblpRV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpRV.Name = "lblpRV";
            this.lblpRV.Size = new System.Drawing.Size(190, 17);
            this.lblpRV.TabIndex = 10;
            this.lblpRV.Text = "INTRODUZCA PROVEEDOR";
            this.lblpRV.Click += new System.EventHandler(this.LblpRV_Click);
            // 
            // txtPrv
            // 
            this.txtPrv.Location = new System.Drawing.Point(81, 398);
            this.txtPrv.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrv.Name = "txtPrv";
            this.txtPrv.Size = new System.Drawing.Size(239, 22);
            this.txtPrv.TabIndex = 9;
            this.txtPrv.TextChanged += new System.EventHandler(this.TxtPrv_TextChanged);
            // 
            // btnProv
            // 
            this.btnProv.Location = new System.Drawing.Point(95, 472);
            this.btnProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(197, 65);
            this.btnProv.TabIndex = 8;
            this.btnProv.Text = "CONSULTAR POR PROVEEDOR";
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.BtnProv_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFecha.Location = new System.Drawing.Point(549, 343);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(147, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "INTRODUZCA FECHA";
            this.lblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // txtFech
            // 
            this.txtFech.Location = new System.Drawing.Point(502, 398);
            this.txtFech.Margin = new System.Windows.Forms.Padding(4);
            this.txtFech.Name = "txtFech";
            this.txtFech.Size = new System.Drawing.Size(239, 22);
            this.txtFech.TabIndex = 12;
            this.txtFech.TextChanged += new System.EventHandler(this.TxtFech_TextChanged);
            // 
            // btnFech
            // 
            this.btnFech.Location = new System.Drawing.Point(521, 472);
            this.btnFech.Margin = new System.Windows.Forms.Padding(4);
            this.btnFech.Name = "btnFech";
            this.btnFech.Size = new System.Drawing.Size(197, 65);
            this.btnFech.TabIndex = 11;
            this.btnFech.Text = "CONSULTAR POR FECHA";
            this.btnFech.UseVisualStyleBackColor = true;
            this.btnFech.Click += new System.EventHandler(this.BtnFech_Click);
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblArt.Location = new System.Drawing.Point(925, 343);
            this.lblArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(171, 17);
            this.lblArt.TabIndex = 16;
            this.lblArt.Text = "INTRODUZCA ARTICULO";
            this.lblArt.Click += new System.EventHandler(this.LblArt_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(897, 398);
            this.txtArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(239, 22);
            this.txtArt.TabIndex = 15;
            this.txtArt.TextChanged += new System.EventHandler(this.TxtArt_TextChanged);
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(911, 472);
            this.btnArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(197, 65);
            this.btnArt.TabIndex = 14;
            this.btnArt.Text = "CONSULTAR POR ARTICULO";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.BtnArt_Click);
            // 
            // dBaseDeDatos1
            // 
            this.dBaseDeDatos1.DataSetName = "DBaseDeDatos";
            this.dBaseDeDatos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstadisticasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 669);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnArt);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFech);
            this.Controls.Add(this.btnFech);
            this.Controls.Add(this.lblpRV);
            this.Controls.Add(this.txtPrv);
            this.Controls.Add(this.btnProv);
            this.Controls.Add(this.dgvCompras);
            this.Name = "EstadisticasCompras";
            this.Text = "EstadisticasCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBaseDeDatos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label lblpRV;
        private System.Windows.Forms.TextBox txtPrv;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFech;
        private System.Windows.Forms.Button btnFech;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnArt;
        private DBaseDeDatos dBaseDeDatos1;
    }
}