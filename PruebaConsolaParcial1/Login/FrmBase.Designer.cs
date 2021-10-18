
namespace Login
{
    partial class FrmBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.tmrDesloguear = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrDesloguear
            // 
            this.tmrDesloguear.Interval = 20000;
            this.tmrDesloguear.Tick += new System.EventHandler(this.tmrDesloguear_Tick);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.FondoApp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmBase_Paint);
            this.MouseHover += new System.EventHandler(this.FrmBase_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDesloguear;
    }
}