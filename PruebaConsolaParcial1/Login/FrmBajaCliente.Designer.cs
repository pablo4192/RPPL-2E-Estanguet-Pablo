
namespace Login
{
    partial class FrmBajaCliente
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
            this.lblMenuBajaCliente = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblDatosAEliminar = new System.Windows.Forms.Label();
            this.txtDatosClienteBaja = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuBajaCliente
            // 
            this.lblMenuBajaCliente.AutoSize = true;
            this.lblMenuBajaCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuBajaCliente.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuBajaCliente.Location = new System.Drawing.Point(12, 9);
            this.lblMenuBajaCliente.Name = "lblMenuBajaCliente";
            this.lblMenuBajaCliente.Size = new System.Drawing.Size(268, 28);
            this.lblMenuBajaCliente.TabIndex = 0;
            this.lblMenuBajaCliente.Text = "Menu Baja Cliente";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(286, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(738, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 44);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Eliminar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(626, 131);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 44);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 178);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersWidth = 51;
            this.dgvListaClientes.RowTemplate.Height = 29;
            this.dgvListaClientes.Size = new System.Drawing.Size(834, 306);
            this.dgvListaClientes.TabIndex = 4;
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroCliente.Location = new System.Drawing.Point(12, 64);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(253, 17);
            this.lblNumeroCliente.TabIndex = 5;
            this.lblNumeroCliente.Text = "Ingrese numero cliente a eliminar";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(271, 56);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.PlaceholderText = "Numero Cliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(149, 27);
            this.txtNumeroCliente.TabIndex = 6;
            // 
            // lblDatosAEliminar
            // 
            this.lblDatosAEliminar.AutoSize = true;
            this.lblDatosAEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosAEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosAEliminar.Location = new System.Drawing.Point(12, 105);
            this.lblDatosAEliminar.Name = "lblDatosAEliminar";
            this.lblDatosAEliminar.Size = new System.Drawing.Size(179, 17);
            this.lblDatosAEliminar.TabIndex = 7;
            this.lblDatosAEliminar.Text = "Datos cliente a eliminar";
            this.lblDatosAEliminar.Visible = false;
            // 
            // txtDatosClienteBaja
            // 
            this.txtDatosClienteBaja.Location = new System.Drawing.Point(197, 98);
            this.txtDatosClienteBaja.Name = "txtDatosClienteBaja";
            this.txtDatosClienteBaja.Size = new System.Drawing.Size(649, 27);
            this.txtDatosClienteBaja.TabIndex = 8;
            this.txtDatosClienteBaja.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(12, 155);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(52, 17);
            this.lblAviso.TabIndex = 9;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(426, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 29);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtDatosClienteBaja);
            this.Controls.Add(this.lblDatosAEliminar);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuBajaCliente);
            this.Name = "FrmBajaCliente";
            this.Text = "FrmBajaCliente";
            this.Load += new System.EventHandler(this.FrmBajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuBajaCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblDatosAEliminar;
        private System.Windows.Forms.TextBox txtDatosClienteBaja;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnBuscar;
    }
}