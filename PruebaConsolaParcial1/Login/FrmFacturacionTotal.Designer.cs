
namespace Login
{
    partial class FrmFacturacionTotal
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
            this.txtMes = new System.Windows.Forms.TextBox();
            this.dgvListaVentasDelMes = new System.Windows.Forms.DataGridView();
            this.lblTotalDelMes = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentasDelMes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(12, 11);
            this.txtMes.Name = "txtMes";
            this.txtMes.PlaceholderText = "Ingrese Numero Mes para ver Facturacion";
            this.txtMes.Size = new System.Drawing.Size(285, 27);
            this.txtMes.TabIndex = 1;
            // 
            // dgvListaVentasDelMes
            // 
            this.dgvListaVentasDelMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentasDelMes.Location = new System.Drawing.Point(12, 128);
            this.dgvListaVentasDelMes.Name = "dgvListaVentasDelMes";
            this.dgvListaVentasDelMes.RowHeadersWidth = 51;
            this.dgvListaVentasDelMes.RowTemplate.Height = 29;
            this.dgvListaVentasDelMes.Size = new System.Drawing.Size(569, 209);
            this.dgvListaVentasDelMes.TabIndex = 2;
            // 
            // lblTotalDelMes
            // 
            this.lblTotalDelMes.AutoSize = true;
            this.lblTotalDelMes.Location = new System.Drawing.Point(12, 83);
            this.lblTotalDelMes.Name = "lblTotalDelMes";
            this.lblTotalDelMes.Size = new System.Drawing.Size(101, 20);
            this.lblTotalDelMes.TabIndex = 3;
            this.lblTotalDelMes.Text = "Total del mes:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(119, 83);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 20);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "label1";
            this.lblMonto.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(203, 44);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 105);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 6;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // FrmFacturacionTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 349);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTotalDelMes);
            this.Controls.Add(this.dgvListaVentasDelMes);
            this.Controls.Add(this.txtMes);
            this.Name = "FrmFacturacionTotal";
            this.Text = "FrmFacturacionTotal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentasDelMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.DataGridView dgvListaVentasDelMes;
        private System.Windows.Forms.Label lblTotalDelMes;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAviso;
    }
}