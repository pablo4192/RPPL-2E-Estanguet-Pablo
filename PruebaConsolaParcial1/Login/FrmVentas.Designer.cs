
namespace Login
{
    partial class FrmVentas
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
            this.lblMenuVentas = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.dgvListaCompra = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuVentas
            // 
            this.lblMenuVentas.AutoSize = true;
            this.lblMenuVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuVentas.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuVentas.Location = new System.Drawing.Point(12, 9);
            this.lblMenuVentas.Name = "lblMenuVentas";
            this.lblMenuVentas.Size = new System.Drawing.Size(276, 28);
            this.lblMenuVentas.TabIndex = 0;
            this.lblMenuVentas.Text = "Menu Nueva Venta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(310, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(520, 184);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(131, 47);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarVenta.Location = new System.Drawing.Point(657, 184);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(131, 47);
            this.btnConfirmarVenta.TabIndex = 3;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoProducto.Location = new System.Drawing.Point(20, 118);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(131, 17);
            this.lblCodigoProducto.TabIndex = 4;
            this.lblCodigoProducto.Text = "Codigo Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(73, 167);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(158, 115);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.PlaceholderText = "Ingrese codigo producto";
            this.txtCodigoProd.Size = new System.Drawing.Size(172, 27);
            this.txtCodigoProd.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(158, 157);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "Ingrese cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(172, 27);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCliente.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroCliente.Location = new System.Drawing.Point(29, 76);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(123, 17);
            this.lblNumeroCliente.TabIndex = 8;
            this.lblNumeroCliente.Text = "Numero Cliente";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(158, 73);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.PlaceholderText = "Ingrese numero cliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(172, 27);
            this.txtNumeroCliente.TabIndex = 9;
            // 
            // dgvListaCompra
            // 
            this.dgvListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompra.Location = new System.Drawing.Point(12, 237);
            this.dgvListaCompra.Name = "dgvListaCompra";
            this.dgvListaCompra.RowHeadersWidth = 51;
            this.dgvListaCompra.RowTemplate.Height = 29;
            this.dgvListaCompra.Size = new System.Drawing.Size(776, 207);
            this.dgvListaCompra.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(336, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 27);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Location = new System.Drawing.Point(336, 122);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCliente.Location = new System.Drawing.Point(336, 80);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(50, 20);
            this.lblDatosCliente.TabIndex = 13;
            this.lblDatosCliente.Text = "label1";
            this.lblDatosCliente.Visible = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarProducto.Location = new System.Drawing.Point(336, 202);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(143, 29);
            this.btnEliminarProducto.TabIndex = 14;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImporte.Location = new System.Drawing.Point(80, 211);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(64, 17);
            this.lblImporte.TabIndex = 15;
            this.lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(158, 204);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(172, 27);
            this.txtImporte.TabIndex = 16;
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.BackColor = System.Drawing.Color.Transparent;
            this.chkEnvio.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEnvio.Location = new System.Drawing.Point(520, 157);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(161, 21);
            this.chkEnvio.TabIndex = 17;
            this.chkEnvio.Text = "Envio a Domicilio";
            this.chkEnvio.UseVisualStyleBackColor = false;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkEnvio);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvListaCompra);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuVentas);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
           
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuVentas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.DataGridView dgvListaCompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.CheckBox chkEnvio;
        private System.Windows.Forms.TextBox txtImporte;
    }
}