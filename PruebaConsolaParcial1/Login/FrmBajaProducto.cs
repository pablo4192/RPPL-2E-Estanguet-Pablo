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
    public partial class FrmBajaProducto : Form
    {
        private FrmBajaProducto()
        {
            InitializeComponent();
        }

        public FrmBajaProducto(string usuario): this()
        {
            lblUsuario.Text = usuario;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string marca = this.txtMarca.Text;
            string legajo = this.txtLegajo.Text;

            if(!Comercio.BajaProducto(nombre, marca, legajo))
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos(lblUsuario.Text);
            frmProducto.Show();
            this.Hide();
        }

        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtLegajo.Text = string.Empty;
        }

        private void FrmBajaProducto_Load(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = Comercio.ListaProductos;
            lblAviso.Visible = false;
        }
    }
}
