
namespace Login
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAutoCompletar = new System.Windows.Forms.Button();
            this.btnCompAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(272, 157);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese usuario";
            this.txtUsuario.Size = new System.Drawing.Size(231, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(272, 232);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "Ingrese contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(231, 27);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(191, 160);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(167, 232);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(83, 20);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(257, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(256, 31);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Bienvenido a Cachogos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(417, 311);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 63);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAutoCompletar
            // 
            this.btnAutoCompletar.Location = new System.Drawing.Point(106, 303);
            this.btnAutoCompletar.Name = "btnAutoCompletar";
            this.btnAutoCompletar.Size = new System.Drawing.Size(144, 71);
            this.btnAutoCompletar.TabIndex = 6;
            this.btnAutoCompletar.Text = "AutoCompletar Empleado";
            this.btnAutoCompletar.UseVisualStyleBackColor = true;
            this.btnAutoCompletar.Click += new System.EventHandler(this.btnAutoCompletar_Click);
            // 
            // btnCompAdm
            // 
            this.btnCompAdm.Location = new System.Drawing.Point(257, 303);
            this.btnCompAdm.Name = "btnCompAdm";
            this.btnCompAdm.Size = new System.Drawing.Size(144, 71);
            this.btnCompAdm.TabIndex = 7;
            this.btnCompAdm.Text = "AutoCompletar Administrador";
            this.btnCompAdm.UseVisualStyleBackColor = true;
            this.btnCompAdm.Click += new System.EventHandler(this.btnCompAdm_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 460);
            this.Controls.Add(this.btnCompAdm);
            this.Controls.Add(this.btnAutoCompletar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAutoCompletar;
        private System.Windows.Forms.Button btnCompAdm;
    }
}

