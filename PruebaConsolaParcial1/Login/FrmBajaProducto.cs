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
    public partial class FrmBajaProducto : FrmBase
    {
        Usuario auxEmpleado;

        private FrmBajaProducto()
        {
            InitializeComponent();
            auxEmpleado = new Empleado();
        }

        public FrmBajaProducto(string usuario): this()
        {
            lblUsuario.Text = usuario;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto productoAEliminar;
            

            productoAEliminar = Comercio.BuscarProducto(txtCodigo.Text);
            
            if(productoAEliminar != null && Comercio.VerificarUsuario(txtLegajo.Text, lblUsuario.Text))
            {
                if (!(Comercio.ListaProductos - productoAEliminar))
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "El producto no pudo eliminarse, verifique los datos ingresado.";
                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Green;
                    lblAviso.Text = "Producto eliminado.";
                    this.dgvListaProductos.DataSource = null;
                    this.dgvListaProductos.DataSource = Comercio.ListaProductos;
                    Limpiar();
                }
            }
            else
            {
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "El producto no pudo eliminarse, verifique los datos ingresado.";
            }

            
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos(lblUsuario.Text);
            frmProducto.Show();
            this.Hide();
        }

        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            
            txtLegajo.Text = string.Empty;
        }

        private void FrmBajaProducto_Load(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = Comercio.ListaProductos;
            lblAviso.Visible = false;
        }
    }
}
