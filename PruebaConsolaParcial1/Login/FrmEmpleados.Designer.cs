
namespace Login
{
    partial class FrmEmpleados
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
            this.lblMenuEmpleados = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnBajaEpleado = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuaEmpleado = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDatosEmpleado = new System.Windows.Forms.TextBox();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuEmpleados
            // 
            this.lblMenuEmpleados.AutoSize = true;
            this.lblMenuEmpleados.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuEmpleados.Location = new System.Drawing.Point(12, 9);
            this.lblMenuEmpleados.Name = "lblMenuEmpleados";
            this.lblMenuEmpleados.Size = new System.Drawing.Size(193, 31);
            this.lblMenuEmpleados.TabIndex = 0;
            this.lblMenuEmpleados.Text = "Menu Empleados";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(211, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.Location = new System.Drawing.Point(12, 53);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(122, 52);
            this.btnAltaEmpleado.TabIndex = 2;
            this.btnAltaEmpleado.Text = "Alta Empleado";
            this.btnAltaEmpleado.UseVisualStyleBackColor = true;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(140, 53);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(122, 52);
            this.btnModificarEmpleado.TabIndex = 3;
            this.btnModificarEmpleado.Text = "Modificar Emppleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnBajaEpleado
            // 
            this.btnBajaEpleado.Location = new System.Drawing.Point(268, 53);
            this.btnBajaEpleado.Name = "btnBajaEpleado";
            this.btnBajaEpleado.Size = new System.Drawing.Size(122, 52);
            this.btnBajaEpleado.TabIndex = 4;
            this.btnBajaEpleado.Text = "Baja Empleado";
            this.btnBajaEpleado.UseVisualStyleBackColor = true;
            this.btnBajaEpleado.Click += new System.EventHandler(this.btnBajaEpleado_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(480, 198);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 29);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(580, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 207);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblUsuaEmpleado
            // 
            this.lblUsuaEmpleado.AutoSize = true;
            this.lblUsuaEmpleado.Location = new System.Drawing.Point(239, 207);
            this.lblUsuaEmpleado.Name = "lblUsuaEmpleado";
            this.lblUsuaEmpleado.Size = new System.Drawing.Size(59, 20);
            this.lblUsuaEmpleado.TabIndex = 9;
            this.lblUsuaEmpleado.Text = "Usuario";
            this.lblUsuaEmpleado.Visible = false;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(480, 143);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(55, 20);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo";
            this.lblSueldo.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese Nombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 200);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese Apellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(304, 200);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 27);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.Visible = false;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(549, 136);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PlaceholderText = "Ingrese Sueldo";
            this.txtSueldo.Size = new System.Drawing.Size(125, 27);
            this.txtSueldo.TabIndex = 14;
            this.txtSueldo.Visible = false;
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(12, 261);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.RowHeadersWidth = 51;
            this.dgvListaEmpleados.RowTemplate.Height = 29;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(693, 196);
            this.dgvListaEmpleados.TabIndex = 15;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(12, 238);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(50, 20);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(601, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(414, 78);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 27);
            this.txtBuscar.TabIndex = 18;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(257, 143);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 20);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "Dni";
            this.lblDni.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(304, 136);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese Dni";
            this.txtDni.Size = new System.Drawing.Size(125, 27);
            this.txtDni.TabIndex = 20;
            this.txtDni.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(601, 198);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 29);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDatosEmpleado
            // 
            this.txtDatosEmpleado.Location = new System.Drawing.Point(138, 116);
            this.txtDatosEmpleado.Name = "txtDatosEmpleado";
            this.txtDatosEmpleado.Size = new System.Drawing.Size(557, 27);
            this.txtDatosEmpleado.TabIndex = 22;
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Location = new System.Drawing.Point(12, 123);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(120, 20);
            this.lblDatosEmpleado.TabIndex = 23;
            this.lblDatosEmpleado.Text = "Datos Empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(601, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 50);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblDatosEmpleado);
            this.Controls.Add(this.txtDatosEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblUsuaEmpleado);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBajaEpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnAltaEmpleado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuEmpleados);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuEmpleados;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnBajaEpleado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuaEmpleado;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDatosEmpleado;
        private System.Windows.Forms.Label lblDatosEmpleado;
        private System.Windows.Forms.Button btnEliminar;
    }
}