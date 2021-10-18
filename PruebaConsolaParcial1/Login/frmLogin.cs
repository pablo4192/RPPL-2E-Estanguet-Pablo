using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Login
{
    public partial class FrmLogin : FrmBase
    {
        string usuario;
        string contrasenia;

        public FrmLogin()
        {
            InitializeComponent();
            
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            contrasenia = txtContraseña.Text;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Comercio.Loguearse(usuario, contrasenia);
                
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuario);
                menuPrincipal.Show();
                this.Hide();  
                
                
            }
            catch(UsuarioInvalidoException usuarioInvalidoExcepcion)
            {
                MessageBox.Show(usuarioInvalidoExcepcion.Message);
            }

            
        }


        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "pepe1234";
            txtContraseña.Text = "1001";
        }

        private void btnCompAdm_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "elrobert88";
            txtContraseña.Text = "1005";
        }
    }
}
