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
    public partial class FrmAltaProducto : Form
    {
        private FrmAltaProducto()
        {
            InitializeComponent();
        }

        public FrmAltaProducto(string usuario): this()
        {
            this.lblUsuario.Text = usuario;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductos frmProductos = new FrmProductos(lblUsuario.Text);
            frmProductos.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!Comercio.AltaProducto(txtNombre.Text, txtMarca.Text, txtCantidad.Text, cmbCategoria.SelectedItem.ToString(), txtPrecio.Text))
            {
                this.lblAviso.ForeColor = Color.Red;
                this.lblAviso.Visible = true;
                this.lblAviso.Text = "Hubo un problema al dar de alta el producto, verifique los datos ingresados.";
            }
            else
            {
                this.lblAviso.ForeColor = Color.Green;
                this.lblAviso.Visible = true;
                this.lblAviso.Text = "Producto agregado al stock!";
                this.dgvListaProductos.DataSource = null;
                this.dgvListaProductos.DataSource = Comercio.ListaProductos;
                Limpiar();
            }
            
        }

        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            
        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            this.cmbCategoria.DataSource = Enum.GetValues(typeof(Ecategoria));
            this.dgvListaProductos.DataSource = Comercio.ListaProductos;
        }
    }
}
