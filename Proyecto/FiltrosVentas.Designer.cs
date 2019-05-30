namespace Proyecto
{
    partial class FiltrosVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrosVentas));
            this.lblUni = new System.Windows.Forms.Label();
            this.txtIDCLIENTE = new System.Windows.Forms.TextBox();
            this.btnIDCLiente = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnConsultaFecha = new System.Windows.Forms.Button();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnART = new System.Windows.Forms.Button();
            this.dgvFiltrosVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUni.Location = new System.Drawing.Point(1195, 419);
            this.lblUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(176, 17);
            this.lblUni.TabIndex = 26;
            this.lblUni.Text = "INTRODUZCA ID CLIENTE";
            // 
            // txtIDCLIENTE
            // 
            this.txtIDCLIENTE.Location = new System.Drawing.Point(1184, 486);
            this.txtIDCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCLIENTE.Name = "txtIDCLIENTE";
            this.txtIDCLIENTE.Size = new System.Drawing.Size(239, 22);
            this.txtIDCLIENTE.TabIndex = 25;
            // 
            // btnIDCLiente
            // 
            this.btnIDCLiente.Location = new System.Drawing.Point(1198, 559);
            this.btnIDCLiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnIDCLiente.Name = "btnIDCLiente";
            this.btnIDCLiente.Size = new System.Drawing.Size(197, 65);
            this.btnIDCLiente.TabIndex = 24;
            this.btnIDCLiente.Text = "CONSULTAR POR ID CLIENTE";
            this.btnIDCLiente.UseVisualStyleBackColor = true;
            this.btnIDCLiente.Click += new System.EventHandler(this.btnIDCLiente_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrecio.Location = new System.Drawing.Point(8, 460);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(180, 17);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "INTRODUZCA UNA FECHA";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(5, 521);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(239, 22);
            this.txtFecha.TabIndex = 22;
            // 
            // btnConsultaFecha
            // 
            this.btnConsultaFecha.Location = new System.Drawing.Point(20, 594);
            this.btnConsultaFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaFecha.Name = "btnConsultaFecha";
            this.btnConsultaFecha.Size = new System.Drawing.Size(197, 65);
            this.btnConsultaFecha.TabIndex = 21;
            this.btnConsultaFecha.Text = "CONSULTAR POR UNA FECHA";
            this.btnConsultaFecha.UseVisualStyleBackColor = true;
            this.btnConsultaFecha.Click += new System.EventHandler(this.btnConsultaFecha_Click);
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblArt.Location = new System.Drawing.Point(17, 26);
            this.lblArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(219, 17);
            this.lblArt.TabIndex = 20;
            this.lblArt.Text = "INTRODUZCA ID DEL ARTÍCULO";
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(8, 87);
            this.txtArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(239, 22);
            this.txtArt.TabIndex = 19;
            // 
            // btnART
            // 
            this.btnART.Location = new System.Drawing.Point(23, 160);
            this.btnART.Margin = new System.Windows.Forms.Padding(4);
            this.btnART.Name = "btnART";
            this.btnART.Size = new System.Drawing.Size(197, 65);
            this.btnART.TabIndex = 18;
            this.btnART.Text = "CONSULTAR POR ARTÍCULOS";
            this.btnART.UseVisualStyleBackColor = true;
            this.btnART.Click += new System.EventHandler(this.btnART_Click);
            // 
            // dgvFiltrosVentas
            // 
            this.dgvFiltrosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrosVentas.Location = new System.Drawing.Point(636, 40);
            this.dgvFiltrosVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFiltrosVentas.Name = "dgvFiltrosVentas";
            this.dgvFiltrosVentas.Size = new System.Drawing.Size(759, 185);
            this.dgvFiltrosVentas.TabIndex = 17;
            // 
            // FiltrosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 648);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.txtIDCLIENTE);
            this.Controls.Add(this.btnIDCLiente);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnConsultaFecha);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnART);
            this.Controls.Add(this.dgvFiltrosVentas);
            this.Name = "FiltrosVentas";
            this.Text = "FiltrosVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.TextBox txtIDCLIENTE;
        private System.Windows.Forms.Button btnIDCLiente;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnConsultaFecha;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnART;
        private System.Windows.Forms.DataGridView dgvFiltrosVentas;
    }
}