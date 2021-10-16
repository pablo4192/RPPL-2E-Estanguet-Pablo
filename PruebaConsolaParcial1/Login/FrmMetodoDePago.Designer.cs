
namespace Login
{
    partial class FrmMetodoDePago
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
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkCuentaCorriente = new System.Windows.Forms.CheckBox();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.txtCostoEnvio = new System.Windows.Forms.TextBox();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(25, 186);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(84, 24);
            this.chkEfectivo.TabIndex = 0;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkCuentaCorriente
            // 
            this.chkCuentaCorriente.AutoSize = true;
            this.chkCuentaCorriente.Location = new System.Drawing.Point(25, 235);
            this.chkCuentaCorriente.Name = "chkCuentaCorriente";
            this.chkCuentaCorriente.Size = new System.Drawing.Size(142, 24);
            this.chkCuentaCorriente.TabIndex = 1;
            this.chkCuentaCorriente.Text = "Cuenta Corriente";
            this.chkCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.Location = new System.Drawing.Point(25, 153);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(168, 20);
            this.lblMetodoDePago.TabIndex = 2;
            this.lblMetodoDePago.Text = "Escoja Metodo De Pago";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 38);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(25, 9);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(114, 20);
            this.lblCostoEnvio.TabIndex = 5;
            this.lblCostoEnvio.Text = "Costo Del Envio";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(25, 71);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(99, 20);
            this.lblImporteTotal.TabIndex = 6;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // txtCostoEnvio
            // 
            this.txtCostoEnvio.Location = new System.Drawing.Point(25, 32);
            this.txtCostoEnvio.Name = "txtCostoEnvio";
            this.txtCostoEnvio.Size = new System.Drawing.Size(125, 27);
            this.txtCostoEnvio.TabIndex = 7;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(25, 94);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(125, 27);
            this.txtImporteTotal.TabIndex = 8;
            // 
            // FrmMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 363);
            this.Controls.Add(this.txtImporteTotal);
            this.Controls.Add(this.txtCostoEnvio);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.lblCostoEnvio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.chkCuentaCorriente);
            this.Controls.Add(this.chkEfectivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetodoDePago";
            this.Load += new System.EventHandler(this.FrmMetodoDePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkCuentaCorriente;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.TextBox txtCostoEnvio;
        private System.Windows.Forms.TextBox txtImporteTotal;
    }
}