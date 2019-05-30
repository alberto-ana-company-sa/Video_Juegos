namespace Proyecto
{
    partial class FiltrosStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrosStock));
            this.dgvFiltrosStock = new System.Windows.Forms.DataGridView();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnART = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblUni = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.btnUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltrosStock
            // 
            this.dgvFiltrosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrosStock.Location = new System.Drawing.Point(504, 13);
            this.dgvFiltrosStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFiltrosStock.Name = "dgvFiltrosStock";
            this.dgvFiltrosStock.Size = new System.Drawing.Size(759, 185);
            this.dgvFiltrosStock.TabIndex = 0;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblArt.Location = new System.Drawing.Point(69, 385);
            this.lblArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(219, 17);
            this.lblArt.TabIndex = 10;
            this.lblArt.Text = "INTRODUZCA ID DEL ARTÍCULO";
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(60, 446);
            this.txtArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(239, 22);
            this.txtArt.TabIndex = 9;
            // 
            // btnART
            // 
            this.btnART.Location = new System.Drawing.Point(75, 519);
            this.btnART.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnART.Name = "btnART";
            this.btnART.Size = new System.Drawing.Size(197, 65);
            this.btnART.TabIndex = 8;
            this.btnART.Text = "CONSULTAR POR ARTÍCULOS";
            this.btnART.UseVisualStyleBackColor = true;
            this.btnART.Click += new System.EventHandler(this.BtnART_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrecio.Location = new System.Drawing.Point(507, 385);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(227, 17);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "INTRODUZCA PRECIO DE COSTE";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(504, 446);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(239, 22);
            this.txtPrecio.TabIndex = 12;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(519, 519);
            this.btnPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(197, 65);
            this.btnPrecio.TabIndex = 11;
            this.btnPrecio.Text = "CONSULTAR POR PRECIO COSTE";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.BtnPrecio_Click);
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUni.Location = new System.Drawing.Point(975, 385);
            this.lblUni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(172, 17);
            this.lblUni.TabIndex = 16;
            this.lblUni.Text = "INTRODUZCA UNIDADES";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(955, 446);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(239, 22);
            this.txtUnidades.TabIndex = 15;
            // 
            // btnUnidades
            // 
            this.btnUnidades.Location = new System.Drawing.Point(969, 519);
            this.btnUnidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(197, 65);
            this.btnUnidades.TabIndex = 14;
            this.btnUnidades.Text = "CONSULTAR POR UNIDADES";
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.BtnUnidades_Click);
            // 
            // FiltrosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 668);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.btnUnidades);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnART);
            this.Controls.Add(this.dgvFiltrosStock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FiltrosStock";
            this.Text = "FiltrosStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltrosStock;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnART;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Button btnUnidades;
    }
}