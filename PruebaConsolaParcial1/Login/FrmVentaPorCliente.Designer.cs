
namespace Login
{
    partial class FrmVentaPorCliente
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
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.dgvProductosVendidos = new System.Windows.Forms.DataGridView();
            this.lblVentasCliente = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblListaProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Location = new System.Drawing.Point(12, 97);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.RowHeadersWidth = 51;
            this.dgvListaVentas.RowTemplate.Height = 29;
            this.dgvListaVentas.Size = new System.Drawing.Size(666, 137);
            this.dgvListaVentas.TabIndex = 0;
            this.dgvListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVentas_CellContentClick);
            // 
            // dgvProductosVendidos
            // 
            this.dgvProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVendidos.Location = new System.Drawing.Point(12, 262);
            this.dgvProductosVendidos.Name = "dgvProductosVendidos";
            this.dgvProductosVendidos.RowHeadersWidth = 51;
            this.dgvProductosVendidos.RowTemplate.Height = 29;
            this.dgvProductosVendidos.Size = new System.Drawing.Size(776, 185);
            this.dgvProductosVendidos.TabIndex = 1;
            // 
            // lblVentasCliente
            // 
            this.lblVentasCliente.AutoSize = true;
            this.lblVentasCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVentasCliente.Location = new System.Drawing.Point(12, 21);
            this.lblVentasCliente.Name = "lblVentasCliente";
            this.lblVentasCliente.Size = new System.Drawing.Size(258, 17);
            this.lblVentasCliente.TabIndex = 2;
            this.lblVentasCliente.Text = "Compras realizadas por el cliente:";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(12, 55);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(52, 17);
            this.lblDatosCliente.TabIndex = 3;
            this.lblDatosCliente.Text = "label1";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaProductos.Location = new System.Drawing.Point(12, 239);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(278, 17);
            this.lblListaProductos.TabIndex = 4;
            this.lblListaProductos.Text = "Listado productos vendidos al cliente";
            // 
            // FrmVentaPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblVentasCliente);
            this.Controls.Add(this.dgvProductosVendidos);
            this.Controls.Add(this.dgvListaVentas);
            this.Name = "FrmVentaPorCliente";
            this.Text = "FrmVentaPorCliente";
            this.Load += new System.EventHandler(this.FrmVentaPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.DataGridView dgvProductosVendidos;
        private System.Windows.Forms.Label lblVentasCliente;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblListaProductos;
    }
}