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
    public partial class FrmMenuPrincipal : Form
    {
        private FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(string usuario): this()
        {
            this.lblDatosUsuario.Text = usuario;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas(lblDatosUsuario.Text);
            frmVentas.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(lblDatosUsuario.Text);
            frmProductos.Show();
            this.Hide();
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(lblDatosUsuario.Text);
            frmCliente.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados(lblDatosUsuario.Text);
            frmEmpleados.Show();
            this.Hide();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if(!Comercio.VerificarAdministrador(lblDatosUsuario.Text))
            {
                this.btnEmpleados.Enabled = false;
            }
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            FrmHistorialVentas frmHistorial = new FrmHistorialVentas(lblDatosUsuario.Text);
            frmHistorial.Show();
            this.Hide();
        }
    }
}
