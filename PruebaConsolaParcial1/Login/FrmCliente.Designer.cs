
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
            this.txtClienteBuscado = new System.Windows.Forms.TextBox();
            this.lblClienteBuscado = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 91);
            this.btnAlta.Size = new System.Drawing.Size(144, 41);
            this.btnAlta.Text = "Alta Cliente";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(162, 91);
            this.btnModificar.Text = "Modificar Cliente";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(314, 93);
            this.btnBaja.Size = new System.Drawing.Size(144, 39);
            this.btnBaja.Text = "Baja Cliente";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click_1);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(742, 91);
            this.btnAtras.Size = new System.Drawing.Size(104, 41);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(573, 4);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblMenuCliente
            // 
            this.lblMenuCliente.AutoSize = true;
            this.lblMenuCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuCliente.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuCliente.Location = new System.Drawing.Point(12, 6);
            this.lblMenuCliente.Name = "lblMenuCliente";
            this.lblMenuCliente.Size = new System.Drawing.Size(209, 28);
            this.lblMenuCliente.TabIndex = 0;
            this.lblMenuCliente.Text = "Menu Clientes";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(221, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
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
            // txtClienteBuscado
            // 
            this.txtClienteBuscado.Location = new System.Drawing.Point(162, 38);
            this.txtClienteBuscado.Name = "txtClienteBuscado";
            this.txtClienteBuscado.Size = new System.Drawing.Size(684, 27);
            this.txtClienteBuscado.TabIndex = 10;
            this.txtClienteBuscado.Visible = false;
            // 
            // lblClienteBuscado
            // 
            this.lblClienteBuscado.AutoSize = true;
            this.lblClienteBuscado.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteBuscado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteBuscado.Location = new System.Drawing.Point(12, 48);
            this.lblClienteBuscado.Name = "lblClienteBuscado";
            this.lblClienteBuscado.Size = new System.Drawing.Size(129, 17);
            this.lblClienteBuscado.TabIndex = 11;
            this.lblClienteBuscado.Text = "Datos del cliente";
            this.lblClienteBuscado.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(506, 45);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(52, 17);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblClienteBuscado);
            this.Controls.Add(this.txtClienteBuscado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Controls.SetChildIndex(this.lblMenuCliente, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.dgvListaClientes, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.txtClienteBuscado, 0);
            this.Controls.SetChildIndex(this.lblClienteBuscado, 0);
            this.Controls.SetChildIndex(this.lblAviso, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnBaja, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtClienteBuscado;
        private System.Windows.Forms.Label lblClienteBuscado;
        private System.Windows.Forms.Label lblAviso;
    }
}