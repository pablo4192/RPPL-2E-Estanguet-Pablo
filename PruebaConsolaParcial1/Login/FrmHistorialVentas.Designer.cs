
namespace Login
{
    partial class FrmHistorialVentas
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
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.lblMenuHistorialVentas = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(12, 122);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.RowHeadersWidth = 51;
            this.dgvHistorialVentas.RowTemplate.Height = 29;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(776, 316);
            this.dgvHistorialVentas.TabIndex = 0;
            // 
            // lblMenuHistorialVentas
            // 
            this.lblMenuHistorialVentas.AutoSize = true;
            this.lblMenuHistorialVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuHistorialVentas.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuHistorialVentas.Location = new System.Drawing.Point(12, 21);
            this.lblMenuHistorialVentas.Name = "lblMenuHistorialVentas";
            this.lblMenuHistorialVentas.Size = new System.Drawing.Size(289, 28);
            this.lblMenuHistorialVentas.TabIndex = 1;
            this.lblMenuHistorialVentas.Text = "Historial de ventas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(307, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "label1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(198, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Venta";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(694, 88);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 32);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 93);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Ingrese numero de cliente";
            this.txtBuscar.Size = new System.Drawing.Size(180, 27);
            this.txtBuscar.TabIndex = 5;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(12, 70);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(52, 17);
            this.lblAviso.TabIndex = 6;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFacturacionTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturacionTotal.Location = new System.Drawing.Point(325, 88);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(159, 31);
            this.btnFacturacionTotal.TabIndex = 7;
            this.btnFacturacionTotal.Text = "Ver Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = false;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // FrmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuHistorialVentas);
            this.Controls.Add(this.dgvHistorialVentas);
            this.Name = "FrmHistorialVentas";
            this.Text = "FrmHistorialVentas";
            this.Load += new System.EventHandler(this.FrmHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Label lblMenuHistorialVentas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnFacturacionTotal;
    }
}