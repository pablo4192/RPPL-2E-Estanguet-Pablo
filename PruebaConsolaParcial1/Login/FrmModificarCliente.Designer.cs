
namespace Login
{
    partial class FrmModificarCliente
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
            this.lblMenuModificarCliente = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.chkPoseeCuenta = new System.Windows.Forms.CheckBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuModificarCliente
            // 
            this.lblMenuModificarCliente.AutoSize = true;
            this.lblMenuModificarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuModificarCliente.Location = new System.Drawing.Point(13, 20);
            this.lblMenuModificarCliente.Name = "lblMenuModificarCliente";
            this.lblMenuModificarCliente.Size = new System.Drawing.Size(192, 31);
            this.lblMenuModificarCliente.TabIndex = 0;
            this.lblMenuModificarCliente.Text = "Modificar Cliente";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(211, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 180);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersWidth = 51;
            this.dgvListaClientes.RowTemplate.Height = 29;
            this.dgvListaClientes.Size = new System.Drawing.Size(834, 304);
            this.dgvListaClientes.TabIndex = 2;
            this.dgvListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaClientes_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(188, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(22, 60);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "Ingrese numero cliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(160, 27);
            this.txtBuscarCliente.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(22, 154);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(66, 20);
            this.lblApelido.TabIndex = 6;
            this.lblApelido.Text = "Apellido";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(276, 106);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 20);
            this.lblCuit.TabIndex = 7;
            this.lblCuit.Text = "Cuit";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(741, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 31);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(620, 140);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 31);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Campo sin modificar";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(94, 147);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Campo sin modificar";
            this.txtApellido.Size = new System.Drawing.Size(149, 27);
            this.txtApellido.TabIndex = 11;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(317, 99);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PlaceholderText = "Campo sin modificar";
            this.txtCuit.Size = new System.Drawing.Size(150, 27);
            this.txtCuit.TabIndex = 12;
            // 
            // chkPoseeCuenta
            // 
            this.chkPoseeCuenta.AutoSize = true;
            this.chkPoseeCuenta.Enabled = false;
            this.chkPoseeCuenta.Location = new System.Drawing.Point(348, 147);
            this.chkPoseeCuenta.Name = "chkPoseeCuenta";
            this.chkPoseeCuenta.Size = new System.Drawing.Size(119, 24);
            this.chkPoseeCuenta.TabIndex = 13;
            this.chkPoseeCuenta.Text = "Posee Cuenta";
            this.chkPoseeCuenta.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(520, 106);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 20);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(573, 99);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(125, 27);
            this.txtSaldo.TabIndex = 15;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(317, 63);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.Text = "label1";
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.chkPoseeCuenta);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuModificarCliente);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarCliente";
            this.Load += new System.EventHandler(this.FrmModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuModificarCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.CheckBox chkPoseeCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblAviso;
    }
}