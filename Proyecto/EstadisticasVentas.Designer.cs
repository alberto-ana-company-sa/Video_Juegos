namespace Proyecto
{
    partial class EstadisticasVentas
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
            this.dgvEstadisticasvENTAS = new System.Windows.Forms.DataGridView();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnArt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFECHA = new System.Windows.Forms.TextBox();
            this.BFECHA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCLIENTE = new System.Windows.Forms.TextBox();
            this.bCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasvENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadisticasvENTAS
            // 
            this.dgvEstadisticasvENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticasvENTAS.Location = new System.Drawing.Point(288, 21);
            this.dgvEstadisticasvENTAS.Name = "dgvEstadisticasvENTAS";
            this.dgvEstadisticasvENTAS.RowHeadersWidth = 51;
            this.dgvEstadisticasvENTAS.RowTemplate.Height = 24;
            this.dgvEstadisticasvENTAS.Size = new System.Drawing.Size(762, 255);
            this.dgvEstadisticasvENTAS.TabIndex = 24;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblArt.Location = new System.Drawing.Point(539, 349);
            this.lblArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(237, 17);
            this.lblArt.TabIndex = 23;
            this.lblArt.Text = "INTRODUZCA ARTICULO VENDIDO";
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(537, 426);
            this.txtArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(239, 22);
            this.txtArt.TabIndex = 22;
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(551, 500);
            this.btnArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(197, 65);
            this.btnArt.TabIndex = 21;
            this.btnArt.Text = "CONSULTAR POR ARTICULO";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(882, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "INTRODUZCA ARTICULO VENDIDO";
            // 
            // TBFECHA
            // 
            this.TBFECHA.Location = new System.Drawing.Point(880, 426);
            this.TBFECHA.Margin = new System.Windows.Forms.Padding(4);
            this.TBFECHA.Name = "TBFECHA";
            this.TBFECHA.Size = new System.Drawing.Size(239, 22);
            this.TBFECHA.TabIndex = 26;
            // 
            // BFECHA
            // 
            this.BFECHA.Location = new System.Drawing.Point(894, 500);
            this.BFECHA.Margin = new System.Windows.Forms.Padding(4);
            this.BFECHA.Name = "BFECHA";
            this.BFECHA.Size = new System.Drawing.Size(197, 65);
            this.BFECHA.TabIndex = 25;
            this.BFECHA.Text = "CONSULTAR POR FECHA";
            this.BFECHA.UseVisualStyleBackColor = true;
            this.BFECHA.Click += new System.EventHandler(this.BFECHA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(212, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "CONSULTAR POR CLIENTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBCLIENTE
            // 
            this.TBCLIENTE.Location = new System.Drawing.Point(210, 426);
            this.TBCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.TBCLIENTE.Name = "TBCLIENTE";
            this.TBCLIENTE.Size = new System.Drawing.Size(239, 22);
            this.TBCLIENTE.TabIndex = 29;
            // 
            // bCliente
            // 
            this.bCliente.Location = new System.Drawing.Point(224, 500);
            this.bCliente.Margin = new System.Windows.Forms.Padding(4);
            this.bCliente.Name = "bCliente";
            this.bCliente.Size = new System.Drawing.Size(197, 65);
            this.bCliente.TabIndex = 28;
            this.bCliente.Text = "CONSULTAR POR CLIENTE";
            this.bCliente.UseVisualStyleBackColor = true;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // EstadisticasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCLIENTE);
            this.Controls.Add(this.bCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFECHA);
            this.Controls.Add(this.BFECHA);
            this.Controls.Add(this.dgvEstadisticasvENTAS);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnArt);
            this.Name = "EstadisticasVentas";
            this.Text = "EstadisticasVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasvENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadisticasvENTAS;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBFECHA;
        private System.Windows.Forms.Button BFECHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBCLIENTE;
        private System.Windows.Forms.Button bCliente;
    }
}