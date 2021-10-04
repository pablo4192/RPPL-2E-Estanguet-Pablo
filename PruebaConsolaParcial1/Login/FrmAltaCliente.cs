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
    public partial class FrmAltaCliente : Form
    {
        bool esAdministrador = false;
        
        private FrmAltaCliente()
        {
            InitializeComponent();
        }

        public FrmAltaCliente(string usuario):this()
        {
            lblUsuario.Text = usuario;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(lblUsuario.Text);
            frmCliente.Show();
            this.Hide();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
            if(Comercio.VerificarAdministrador(lblUsuario.Text))
            {
                chkPoseeCuenta.Enabled = true;
                this.txtSaldo.Enabled = true;
                esAdministrador = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado auxEmpleado = new Empleado("Prueba");
            Administrador auxAdmi = new Administrador("Prueba");

            if(!esAdministrador)
            {
                if (!auxEmpleado.AltaCliente(txtNombre.Text, txtApellido.Text, txtCuit.Text, false, "0"))
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Visible = true;
                    lblAviso.Text = "Hubo un problema al dar de alta el Cliente, verifique datos ingresados, el cliente ya existe?";
                }
                else
                {
                    lblAviso.ForeColor = Color.Green;
                    lblAviso.Visible = true;
                    lblAviso.Text = "Alta Cliente Exitosa!";
                    dgvListaClientes.DataSource = null;
                    dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
                    Limpiar();
                }
            }
            else
            {
                if (!auxAdmi.AltaCliente(txtNombre.Text, txtApellido.Text, txtCuit.Text, chkPoseeCuenta.Checked, txtSaldo.Text))
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Visible = true;
                    lblAviso.Text = "Hubo un problema al dar de alta el Cliente, verifique datos ingresados, el cliente ya existe?";
                }
                else
                {
                    lblAviso.ForeColor = Color.Green;
                    lblAviso.Visible = true;
                    lblAviso.Text = "Alta Cliente Exitosa!";
                    dgvListaClientes.DataSource = null;
                    dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
                    Limpiar();
                }
            }

            
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCuit.Text = string.Empty;
            
        }
    }
}
