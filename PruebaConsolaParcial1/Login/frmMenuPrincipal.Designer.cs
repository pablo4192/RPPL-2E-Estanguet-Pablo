
namespace Login
{
    partial class FrmMenuPrincipal
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.btnCerrarCesion = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.Location = new System.Drawing.Point(12, 108);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(196, 27);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 244);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(151, 59);
            this.btnNuevaVenta.TabIndex = 1;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(361, 244);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(151, 59);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(529, 244);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(151, 59);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(695, 244);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(151, 59);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosUsuario.Location = new System.Drawing.Point(227, 108);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(51, 19);
            this.lblDatosUsuario.TabIndex = 5;
            this.lblDatosUsuario.Text = "label1";
            // 
            // btnCerrarCesion
            // 
            this.btnCerrarCesion.Location = new System.Drawing.Point(672, 85);
            this.btnCerrarCesion.Name = "btnCerrarCesion";
            this.btnCerrarCesion.Size = new System.Drawing.Size(105, 29);
            this.btnCerrarCesion.TabIndex = 6;
            this.btnCerrarCesion.Text = "Cerrar Sesion";
            this.btnCerrarCesion.UseVisualStyleBackColor = true;
            this.btnCerrarCesion.Click += new System.EventHandler(this.btnCerrarCesion_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Location = new System.Drawing.Point(186, 244);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(151, 59);
            this.btnHistorialVentas.TabIndex = 7;
            this.btnHistorialVentas.Text = "Historial Ventas";
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            this.btnHistorialVentas.Click += new System.EventHandler(this.btnHistorialVentas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.historialVentasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.cerrarCesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // historialVentasToolStripMenuItem
            // 
            this.historialVentasToolStripMenuItem.Name = "historialVentasToolStripMenuItem";
            this.historialVentasToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.historialVentasToolStripMenuItem.Text = "Historial Ventas";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // cerrarCesionToolStripMenuItem
            // 
            this.cerrarCesionToolStripMenuItem.Name = "cerrarCesionToolStripMenuItem";
            this.cerrarCesionToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.cerrarCesionToolStripMenuItem.Text = "Cerrar Cesion";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.btnHistorialVentas);
            this.Controls.Add(this.btnCerrarCesion);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblDatosUsuario;
        private System.Windows.Forms.Button btnCerrarCesion;
        private System.Windows.Forms.Button btnHistorialVentas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCesionToolStripMenuItem;
    }
}