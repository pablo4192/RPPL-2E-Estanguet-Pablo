
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDatosEmpleado = new System.Windows.Forms.TextBox();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCamposAModificar = new System.Windows.Forms.Label();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 51);
            this.btnAlta.Size = new System.Drawing.Size(149, 41);
            this.btnAlta.Text = "Alta Empleado";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(167, 51);
            this.btnModificar.Size = new System.Drawing.Size(168, 41);
            this.btnModificar.Text = "Modificar Empleado";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(341, 53);
            this.btnBaja.Size = new System.Drawing.Size(133, 39);
            this.btnBaja.Text = "Baja Empleado";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(480, 198);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(601, 16);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblMenuEmpleados
            // 
            this.lblMenuEmpleados.AutoSize = true;
            this.lblMenuEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuEmpleados.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuEmpleados.Location = new System.Drawing.Point(12, 9);
            this.lblMenuEmpleados.Name = "lblMenuEmpleados";
            this.lblMenuEmpleados.Size = new System.Drawing.Size(242, 28);
            this.lblMenuEmpleados.TabIndex = 0;
            this.lblMenuEmpleados.Text = "Menu Empleados";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(260, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(580, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 207);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 17);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblUsuaEmpleado
            // 
            this.lblUsuaEmpleado.AutoSize = true;
            this.lblUsuaEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuaEmpleado.Location = new System.Drawing.Point(239, 207);
            this.lblUsuaEmpleado.Name = "lblUsuaEmpleado";
            this.lblUsuaEmpleado.Size = new System.Drawing.Size(65, 17);
            this.lblUsuaEmpleado.TabIndex = 9;
            this.lblUsuaEmpleado.Text = "Usuario";
            this.lblUsuaEmpleado.Visible = false;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSueldo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSueldo.Location = new System.Drawing.Point(480, 153);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(58, 17);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo";
            this.lblSueldo.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 146);
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
            this.txtSueldo.Location = new System.Drawing.Point(549, 146);
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
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.Location = new System.Drawing.Point(12, 238);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(52, 17);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.Text = "label1";
            this.lblAviso.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(480, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(115, 27);
            this.txtBuscar.TabIndex = 18;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(266, 153);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 17);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "Dni";
            this.lblDni.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(304, 146);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese Dni";
            this.txtDni.Size = new System.Drawing.Size(125, 27);
            this.txtDni.TabIndex = 20;
            this.txtDni.Visible = false;
            // 
            // txtDatosEmpleado
            // 
            this.txtDatosEmpleado.Location = new System.Drawing.Point(140, 113);
            this.txtDatosEmpleado.Name = "txtDatosEmpleado";
            this.txtDatosEmpleado.Size = new System.Drawing.Size(557, 27);
            this.txtDatosEmpleado.TabIndex = 22;
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosEmpleado.Location = new System.Drawing.Point(12, 126);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(126, 17);
            this.lblDatosEmpleado.TabIndex = 23;
            this.lblDatosEmpleado.Text = "Datos Empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(611, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 50);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCamposAModificar
            // 
            this.lblCamposAModificar.AutoSize = true;
            this.lblCamposAModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblCamposAModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamposAModificar.Location = new System.Drawing.Point(12, 109);
            this.lblCamposAModificar.Name = "lblCamposAModificar";
            this.lblCamposAModificar.Size = new System.Drawing.Size(315, 17);
            this.lblCamposAModificar.TabIndex = 25;
            this.lblCamposAModificar.Text = "Ingrese solamente los campos a modificar";
            this.lblCamposAModificar.Visible = false;
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarEmpleado.Location = new System.Drawing.Point(601, 200);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(104, 29);
            this.btnModificarEmpleado.TabIndex = 26;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Visible = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.lblCamposAModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblDatosEmpleado);
            this.Controls.Add(this.txtDatosEmpleado);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtBuscar);
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
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMenuEmpleados);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.Controls.SetChildIndex(this.lblMenuEmpleados, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblUsuaEmpleado, 0);
            this.Controls.SetChildIndex(this.lblSueldo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.txtSueldo, 0);
            this.Controls.SetChildIndex(this.dgvListaEmpleados, 0);
            this.Controls.SetChildIndex(this.lblAviso, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.txtDatosEmpleado, 0);
            this.Controls.SetChildIndex(this.lblDatosEmpleado, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.lblCamposAModificar, 0);
            this.Controls.SetChildIndex(this.btnAlta, 0);
            this.Controls.SetChildIndex(this.btnBaja, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnModificarEmpleado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuEmpleados;
        private System.Windows.Forms.Label lblUsuario;
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
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        
        private System.Windows.Forms.TextBox txtDatosEmpleado;
        private System.Windows.Forms.Label lblDatosEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCamposAModificar;
        private System.Windows.Forms.Button btnModificarEmpleado;
    }
}