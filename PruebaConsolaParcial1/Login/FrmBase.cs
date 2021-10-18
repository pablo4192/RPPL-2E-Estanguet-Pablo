using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();

        }

        private void FrmBase_MouseHover(object sender, EventArgs e)
        {
            tmrDesloguear.Enabled = true;
        }

        private void FrmBase_Paint(object sender, PaintEventArgs e)
        {
            tmrDesloguear.Enabled = false;
        }

        private void tmrDesloguear_Tick(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        
        

        

        
    }
}
