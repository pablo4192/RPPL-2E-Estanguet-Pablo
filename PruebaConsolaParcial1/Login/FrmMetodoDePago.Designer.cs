﻿
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
            this.SuspendLayout();
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(38, 60);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(84, 24);
            this.chkEfectivo.TabIndex = 0;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkCuentaCorriente
            // 
            this.chkCuentaCorriente.AutoSize = true;
            this.chkCuentaCorriente.Location = new System.Drawing.Point(38, 116);
            this.chkCuentaCorriente.Name = "chkCuentaCorriente";
            this.chkCuentaCorriente.Size = new System.Drawing.Size(142, 24);
            this.chkCuentaCorriente.TabIndex = 1;
            this.chkCuentaCorriente.Text = "Cuenta Corriente";
            this.chkCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.Location = new System.Drawing.Point(12, 18);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(168, 20);
            this.lblMetodoDePago.TabIndex = 2;
            this.lblMetodoDePago.Text = "Escoja Metodo De Pago";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(200, 143);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 184);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.chkCuentaCorriente);
            this.Controls.Add(this.chkEfectivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetodoDePago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkCuentaCorriente;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.Button btnAceptar;
    }
}