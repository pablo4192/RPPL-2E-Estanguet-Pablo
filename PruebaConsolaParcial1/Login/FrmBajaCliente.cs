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
    public partial class FrmBajaCliente : Form
    {
        Usuario auxEmpleado; 

        private FrmBajaCliente()
        {
            InitializeComponent();
            auxEmpleado = new Empleado();
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\iconoPerro.ico");
            this.Icon = icono;
        }
        public FrmBajaCliente(string usuario): this()
        {
            this.lblUsuario.Text = usuario;
        }

        private void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(lblUsuario.Text);
            frmCliente.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Seguro desea eliminar al cliente numero {txtNumeroCliente.Text}?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (auxEmpleado.EliminarCliente(txtNumeroCliente.Text))
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Green;
                    lblAviso.Text = "Cliente dado de baja exitosamente.";
                    dgvListaClientes.DataSource = null;
                    dgvListaClientes.DataSource = Comercio.ListaClientes.Values.ToArray();
                    Limpiar();
                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "Hubo un problema al dar de baja el cliente";
                }
            }

            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int keyInt;

            if(int.TryParse(txtNumeroCliente.Text, out keyInt))
            {
               if(Comercio.ListaClientes.ContainsKey(keyInt))
               {
                    lblDatosAEliminar.Visible = true;
                    txtDatosClienteBaja.Visible = true;
                    txtDatosClienteBaja.Text = Cliente.DatosClienteToString(keyInt);
               }
               else
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "El cliente no se encontro.";
                }
            }
            
        }

        public void Limpiar()
        {
            txtDatosClienteBaja.Text = string.Empty;
            txtDatosClienteBaja.Visible = false;
            lblDatosAEliminar.Visible = false;
            txtNumeroCliente.Text = string.Empty;
        }
    }
}
