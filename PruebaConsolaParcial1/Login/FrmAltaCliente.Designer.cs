
namespace Login
{
    partial class FrmAltaCliente
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
            this.lblMenuAltaCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.chkPoseeCuenta = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuAltaCliente
            // 
            this.lblMenuAltaCliente.AutoSize = true;
            this.lblMenuAltaCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuAltaCliente.Location = new System.Drawing.Point(27, 9);
            this.lblMenuAltaCliente.Name = "lblMenuAltaCliente";
            this.lblMenuAltaCliente.Size = new System.Drawing.Size(197, 31);
            this.lblMenuAltaCliente.TabIndex = 0;
            this.lblMenuAltaCliente.Text = "Menu Alta Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(309, 66);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(47, 20);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "Cuit   ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(571, 70);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 20);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(244, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "label6";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese Nombre Cliente";
            this.txtNombre.Size = new System.Drawing.Size(173, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese Apellido Cliente";
            this.txtApellido.Size = new System.Drawing.Size(173, 27);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(362, 63);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PlaceholderText = "Ingrese Cuit Cliente";
            this.txtCuit.Size = new System.Drawing.Size(173, 27);
            this.txtCuit.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(624, 63);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(173, 27);
            this.txtSaldo.TabIndex = 9;
            // 
            // chkPoseeCuenta
            // 
            this.chkPoseeCuenta.AutoSize = true;
            this.chkPoseeCuenta.Enabled = false;
            this.chkPoseeCuenta.Location = new System.Drawing.Point(351, 110);
            this.chkPoseeCuenta.Name = "chkPoseeCuenta";
            this.chkPoseeCuenta.Size = new System.Drawing.Size(184, 24);
            this.chkPoseeCuenta.TabIndex = 10;
            this.chkPoseeCuenta.Text = "Posee Cuenta Corriente";
            this.chkPoseeCuenta.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(743, 115);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 43);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(607, 115);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(103, 43);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
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
            this.dgvListaClientes.Size = new System.Drawing.Size(834, 297);
            this.dgvListaClientes.TabIndex = 13;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(12, 155);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 14;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 487);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkPoseeCuenta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMenuAltaCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAltaCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.CheckBox chkPoseeCuenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Label lblAviso;
    }
}