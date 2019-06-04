namespace Proyecto
{
    partial class EstadisticasStock
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
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.btnArt = new System.Windows.Forms.Button();
            this.dgvEstadisticasStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblArt.Location = new System.Drawing.Point(556, 432);
            this.lblArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(237, 17);
            this.lblArt.TabIndex = 19;
            this.lblArt.Text = "INTRODUZCA ARTICULO VENDIDO";
            this.lblArt.Click += new System.EventHandler(this.lblArt_Click);
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(554, 488);
            this.txtArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(239, 22);
            this.txtArt.TabIndex = 18;
            this.txtArt.TextChanged += new System.EventHandler(this.txtArt_TextChanged);
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(568, 562);
            this.btnArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(197, 65);
            this.btnArt.TabIndex = 17;
            this.btnArt.Text = "CONSULTAR POR ARTICULO";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.BtnArt_Click_1);
            // 
            // dgvEstadisticasStock
            // 
            this.dgvEstadisticasStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticasStock.Location = new System.Drawing.Point(305, 83);
            this.dgvEstadisticasStock.Name = "dgvEstadisticasStock";
            this.dgvEstadisticasStock.RowHeadersWidth = 51;
            this.dgvEstadisticasStock.RowTemplate.Height = 24;
            this.dgvEstadisticasStock.Size = new System.Drawing.Size(762, 255);
            this.dgvEstadisticasStock.TabIndex = 20;
            this.dgvEstadisticasStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadisticasStock_CellContentClick);
            // 
            // EstadisticasStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 729);
            this.Controls.Add(this.dgvEstadisticasStock);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.btnArt);
            this.Name = "EstadisticasStock";
            this.Text = "EstadisticasStock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticasStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.DataGridView dgvEstadisticasStock;
    }
}