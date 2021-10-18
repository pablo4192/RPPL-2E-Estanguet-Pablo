
namespace Login
{
    partial class FrmProductos
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
            this.lblMenuProductos = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtDatosProducto = new System.Windows.Forms.TextBox();
            this.lblDatosProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 54);
            this.btnAlta.Size = new System.Drawing.Size(158, 41);
            this.btnAlta.Text = "Alta Producto";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(176, 54);
            this.btnModificar.Size = new System.Drawing.Size(158, 41);
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(344, 54);
            this.btnBaja.Size = new System.Drawing.Size(158, 39);
            this.btnBaja.Text = "Baja Producto";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click_1);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(744, 105);
            this.btnAtras.Size = new System.Drawing.Size(102, 39);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(565, 17);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblMenuProductos
            // 
            this.lblMenuProductos.AutoSize = true;
            this.lblMenuProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuProductos.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuProductos.Location = new System.Drawing.Point(12, 9);
            this.lblMenuProductos.Name = "lblMenuProductos";
            this.lblMenuProductos.Size = new System.Drawing.Size(251, 28);
            this.lblMenuProductos.TabIndex = 1;
            this.lblMenuProductos.Text = "Menu Productos";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(665, 19);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PlaceholderText = "Ingrese Codigo producto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(181, 27);
            this.txtBuscarProducto.TabIndex = 5;
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosUsuario.Location = new System.Drawing.Point(269, 17);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblDatosUsuario.TabIndex = 7;
            this.lblDatosUsuario.Text = "label1";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(12, 183);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.RowHeadersWidth = 51;
            this.dgvListaProductos.RowTemplate.Height = 29;
            this.dgvListaProductos.Size = new System.Drawing.Size(834, 301);
            this.dgvListaProductos.TabIndex = 10;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(12, 157);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(52, 17);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // txtDatosProducto
            // 
            this.txtDatosProducto.Location = new System.Drawing.Point(140, 150);
            this.txtDatosProducto.Name = "txtDatosProducto";
            this.txtDatosProducto.Size = new System.Drawing.Size(706, 27);
            this.txtDatosProducto.TabIndex = 13;
            this.txtDatosProducto.Visible = false;
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosProducto.Location = new System.Drawing.Point(18, 157);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(121, 17);
            this.lblDatosProducto.TabIndex = 14;
            this.lblDatosProducto.Text = "Datos Producto";
            this.lblDatosProducto.Visible = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblDatosProducto);
            this.Controls.Add(this.txtDatosProducto);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblMenuProductos);
            this.Name = "FrmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.Controls.SetChildIndex(this.lblMenuProductos, 0);
            this.Controls.SetChildIndex(this.txtBuscarProducto, 0);
            this.Controls.SetChildIndex(this.lblDatosUsuario, 0);
            this.Controls.SetChildIndex(this.dgvListaProductos, 0);
            this.Controls.SetChildIndex(this.lblAviso, 0);
            this.Controls.SetChildIndex(this.txtDatosProducto, 0);
            this.Controls.SetChildIndex(this.lblDatosProducto, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnBaja, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenuProductos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblDatosUsuario;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtDatosProducto;
        private System.Windows.Forms.Label lblDatosProducto;
    }
}