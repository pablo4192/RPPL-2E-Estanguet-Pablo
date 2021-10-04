
namespace Login
{
    partial class FrmCliente
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
            this.lblMenuCliente = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClienteBuscado = new System.Windows.Forms.TextBox();
            this.lblClienteBuscado = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCliente
            // 
            this.lblMenuCliente.AutoSize = true;
            this.lblMenuCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuCliente.Location = new System.Drawing.Point(12, 6);
            this.lblMenuCliente.Name = "lblMenuCliente";
            this.lblMenuCliente.Size = new System.Drawing.Size(160, 31);
            this.lblMenuCliente.TabIndex = 0;
            this.lblMenuCliente.Text = "Menu Clientes";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(187, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(12, 138);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersWidth = 51;
            this.dgvListaClientes.RowTemplate.Height = 29;
            this.dgvListaClientes.Size = new System.Drawing.Size(834, 346);
            this.dgvListaClientes.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(673, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Ingrese Numero Cliente";
            this.txtBuscar.Size = new System.Drawing.Size(173, 27);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(12, 83);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(94, 49);
            this.btnAltaCliente.TabIndex = 5;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(121, 83);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(94, 49);
            this.btnModificarCliente.TabIndex = 6;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Location = new System.Drawing.Point(221, 83);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(94, 49);
            this.btnBajaCliente.TabIndex = 7;
            this.btnBajaCliente.Text = "BajaCliente";
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(332, 83);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 49);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(573, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtClienteBuscado
            // 
            this.txtClienteBuscado.Location = new System.Drawing.Point(221, 38);
            this.txtClienteBuscado.Name = "txtClienteBuscado";
            this.txtClienteBuscado.Size = new System.Drawing.Size(625, 27);
            this.txtClienteBuscado.TabIndex = 10;
            this.txtClienteBuscado.Visible = false;
            // 
            // lblClienteBuscado
            // 
            this.lblClienteBuscado.AutoSize = true;
            this.lblClienteBuscado.Location = new System.Drawing.Point(94, 46);
            this.lblClienteBuscado.Name = "lblClienteBuscado";
            this.lblClienteBuscado.Size = new System.Drawing.Size(121, 20);
            this.lblClienteBuscado.TabIndex = 11;
            this.lblClienteBuscado.Text = "Datos del cliente";
            this.lblClienteBuscado.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(506, 37);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblClienteBuscado);
            this.Controls.Add(this.txtClienteBuscado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBajaCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuCliente);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtClienteBuscado;
        private System.Windows.Forms.Label lblClienteBuscado;
        private System.Windows.Forms.Label lblAviso;
    }
}