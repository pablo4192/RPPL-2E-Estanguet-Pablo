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
    public partial class FrmModificarCliente : FrmBase
    {
        Cliente clienteAModificar;

        private FrmModificarCliente()
        {
            InitializeComponent();
            Icon icono = new Icon(Application.StartupPath + @"Iconos\iconoPerro.ico");
            this.Icon = icono;
        }

        public FrmModificarCliente(string usuario): this()
        {
            this.lblUsuario.Text = usuario;
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            this.dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
            this.btnGuardar.Enabled = false;
            if(Comercio.VerificarAdministrador(lblUsuario.Text))
            {
                chkPoseeCuenta.Enabled = true;
                txtSaldo.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroCliente;
            this.lblAviso.Visible = false;

            if(int.TryParse(this.txtBuscarCliente.Text, out numeroCliente))
            {
                if(Comercio.ListaClientes.ContainsKey(numeroCliente))
                {
                    clienteAModificar = Comercio.ListaClientes[numeroCliente];

                    txtNombre.Text = clienteAModificar.Nombre;
                    txtApellido.Text = clienteAModificar.Apellido;
                    txtCuit.Text = clienteAModificar.Cuit;
                    chkPoseeCuenta.Checked = clienteAModificar.PoseeCuenta;
                    txtSaldo.Text = clienteAModificar.Saldo.ToString();
                    this.btnGuardar.Enabled = true;

                }
                else
                {
                    this.lblAviso.Visible = true;
                    this.lblAviso.ForeColor = Color.Red;
                    this.lblAviso.Text = "El numero de cliente buscado no es valido";
                }

            }
            else
            {
                this.lblAviso.Visible = true;
                this.lblAviso.ForeColor = Color.Red;
                this.lblAviso.Text = "El numero de cliente buscado no es valido";
            }
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteAModificar = (Cliente)dgvListaClientes.CurrentRow.DataBoundItem;
            lblAviso.Visible = false;

            txtNombre.Text = clienteAModificar.Nombre;
            txtApellido.Text = clienteAModificar.Apellido;
            txtCuit.Text = clienteAModificar.Cuit;
            chkPoseeCuenta.Checked = clienteAModificar.PoseeCuenta;
            txtSaldo.Text = clienteAModificar.Saldo.ToString();
            this.btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado auxEmpleado = new Empleado();
            
            lblAviso.Visible = true;

            if(Comercio.ValidarCliente(txtNombre.Text, txtApellido.Text, txtCuit.Text, chkPoseeCuenta.Checked, txtSaldo.Text))
            {
                clienteAModificar.Nombre = txtNombre.Text;
                clienteAModificar.Apellido = txtApellido.Text;
                clienteAModificar.Cuit = txtCuit.Text;
                clienteAModificar.PoseeCuenta = chkPoseeCuenta.Checked;
                clienteAModificar.Saldo = float.Parse(txtSaldo.Text);

                if (auxEmpleado.ModificarCliente(clienteAModificar))
                {
                    lblAviso.ForeColor = Color.Green;
                    this.lblAviso.Text = "Cliente modificado con exito";
                    this.dgvListaClientes.DataSource = null;
                    this.dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
                }
                else
                {
                    lblAviso.ForeColor = Color.Red;
                    this.lblAviso.Text = "No se pudo modificar al cliente, verifique datos ingresados";
                }
            }
            else
            {
                lblAviso.ForeColor = Color.Red;
                this.lblAviso.Text = "No se pudo modificar al cliente, verifique datos ingresados";
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(lblUsuario.Text);
            frmCliente.Show();
            this.Hide();
        }

        
    }
}
