
namespace Login
{
    partial class FrmBajaProducto
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
            this.lblMenuBajaProducto = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuBajaProducto
            // 
            this.lblMenuBajaProducto.AutoSize = true;
            this.lblMenuBajaProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuBajaProducto.Location = new System.Drawing.Point(12, 23);
            this.lblMenuBajaProducto.Name = "lblMenuBajaProducto";
            this.lblMenuBajaProducto.Size = new System.Drawing.Size(225, 31);
            this.lblMenuBajaProducto.TabIndex = 0;
            this.lblMenuBajaProducto.Text = "Menu Baja Producto";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(262, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(46, 126);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(410, 79);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(135, 20);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Contraseña usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese Nombre producto a eliminar";
            this.txtNombre.Size = new System.Drawing.Size(254, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(111, 119);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Ingrese Marca producto a eliminar";
            this.txtMarca.Size = new System.Drawing.Size(254, 27);
            this.txtMarca.TabIndex = 6;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(551, 72);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.PlaceholderText = "Ingrese Contraseña (Legajo)";
            this.txtLegajo.Size = new System.Drawing.Size(254, 27);
            this.txtLegajo.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(734, 142);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(602, 142);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(116, 41);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(12, 188);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersWidth = 51;
            this.dgvListaProductos.RowTemplate.Height = 29;
            this.dgvListaProductos.Size = new System.Drawing.Size(834, 296);
            this.dgvListaProductos.TabIndex = 10;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 163);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 11;
            this.lblAviso.Text = "label1";
            // 
            // FrmBajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuBajaProducto);
            this.Name = "FrmBajaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBajaProducto";
            this.Load += new System.EventHandler(this.FrmBajaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuBajaProducto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblAviso;
    }
}