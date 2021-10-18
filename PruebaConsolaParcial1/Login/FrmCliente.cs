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
    public partial class FrmCliente : FrmBaseAbm
    {
        
        private FrmCliente()
        {
            InitializeComponent();
            
        }

        public FrmCliente(string usuario): this()
        {
            lblUsuario.Text = usuario;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
            if(!Comercio.VerificarAdministrador(lblUsuario.Text))
            {
                btnAlta.Enabled = false;
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente(lblUsuario.Text);
            frmAltaCliente.Show();
            this.Hide();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            FrmModificarCliente frmModificarCliente = new FrmModificarCliente(lblUsuario.Text);
            frmModificarCliente.Show();
            this.Hide();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            FrmBajaCliente frmBajaCliente = new FrmBajaCliente(lblUsuario.Text);
            frmBajaCliente.Show();
            this.Hide();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(lblUsuario.Text);
            frmMenu.Show();
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int keyInt;
            dgvListaClientes.CurrentCell.Selected = false;
            this.dgvListaClientes.CurrentRow.Selected = false;

            if (int.TryParse(this.txtBuscar.Text, out keyInt))
            {
                if (Comercio.ListaClientes.ContainsKey(keyInt))
                {
                    lblAviso.Visible = false;
                    this.lblClienteBuscado.Visible = true;
                    this.txtClienteBuscado.Visible = true;
                    this.txtClienteBuscado.Text = Cliente.DatosClienteToString(keyInt);
                }
                else
                {
                    this.lblClienteBuscado.Visible = false;
                    this.txtClienteBuscado.Visible = false;
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "El numero de cliente buscado no es valido";
                }
            }
        }
    }
}
