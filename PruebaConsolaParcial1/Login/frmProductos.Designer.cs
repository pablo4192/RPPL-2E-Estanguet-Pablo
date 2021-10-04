
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
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnBajaProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtDatosProducto = new System.Windows.Forms.TextBox();
            this.lblDatosProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuProductos
            // 
            this.lblMenuProductos.AutoSize = true;
            this.lblMenuProductos.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuProductos.Location = new System.Drawing.Point(12, 16);
            this.lblMenuProductos.Name = "lblMenuProductos";
            this.lblMenuProductos.Size = new System.Drawing.Size(203, 34);
            this.lblMenuProductos.TabIndex = 1;
            this.lblMenuProductos.Text = "Menu Productos";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(12, 74);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(141, 49);
            this.btnAltaProducto.TabIndex = 2;
            this.btnAltaProducto.Text = "Alta Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(160, 74);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(141, 49);
            this.btnModificarProducto.TabIndex = 3;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnBajaProducto
            // 
            this.btnBajaProducto.Location = new System.Drawing.Point(317, 74);
            this.btnBajaProducto.Name = "btnBajaProducto";
            this.btnBajaProducto.Size = new System.Drawing.Size(141, 49);
            this.btnBajaProducto.TabIndex = 4;
            this.btnBajaProducto.Text = "Baja Producto";
            this.btnBajaProducto.UseVisualStyleBackColor = true;
            this.btnBajaProducto.Click += new System.EventHandler(this.btnBajaProducto_Click);
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
            this.lblDatosUsuario.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosUsuario.Location = new System.Drawing.Point(221, 28);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(51, 19);
            this.lblDatosUsuario.TabIndex = 7;
            this.lblDatosUsuario.Text = "label1";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(478, 94);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 29);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(565, 18);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(94, 29);
            this.btnBuscarProducto.TabIndex = 11;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 157);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // txtDatosProducto
            // 
            this.txtDatosProducto.Location = new System.Drawing.Point(136, 150);
            this.txtDatosProducto.Name = "txtDatosProducto";
            this.txtDatosProducto.Size = new System.Drawing.Size(710, 27);
            this.txtDatosProducto.TabIndex = 13;
            this.txtDatosProducto.Visible = false;
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.Location = new System.Drawing.Point(18, 157);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(112, 20);
            this.lblDatosProducto.TabIndex = 14;
            this.lblDatosProducto.Text = "Datos Producto";
            this.lblDatosProducto.Visible = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblDatosProducto);
            this.Controls.Add(this.txtDatosProducto);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnBajaProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.lblMenuProductos);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenuProductos;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnBajaProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblDatosUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtDatosProducto;
        private System.Windows.Forms.Label lblDatosProducto;
    }
}