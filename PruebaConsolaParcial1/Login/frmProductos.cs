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
    public partial class FrmProductos : FrmBaseAbm
    {
        

        private FrmProductos()
        {
            InitializeComponent();
            Icon icono = new Icon(Application.StartupPath + @"Iconos\iconoPerro.ico");
            this.Icon = icono;
        }

        public FrmProductos(string usuario): this()
        {
            this.lblDatosUsuario.Text = usuario;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = Comercio.ListaProductos;
        }

       
        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            FrmAltaProducto frmAltaProducto = new FrmAltaProducto(lblDatosUsuario.Text);
            frmAltaProducto.Show();
            this.Hide();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            FrmModicarProducto frmModificar = new FrmModicarProducto(lblDatosUsuario.Text);
            frmModificar.Show();
            this.Hide();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            FrmBajaProducto frmBajaProducto = new FrmBajaProducto(lblDatosUsuario.Text);
            frmBajaProducto.Show();
            this.Hide();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(lblDatosUsuario.Text);
            frmMenuPrincipal.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Producto producto = Comercio.BuscarProducto(txtBuscarProducto.Text);
            if (producto != null)
            {
                lblAviso.Visible = false;
                lblDatosProducto.Visible = true;
                txtDatosProducto.Visible = true;
                txtDatosProducto.Text = Producto.DatosProductoToString(producto);
            }
            else
            {
                lblDatosProducto.Visible = false;
                txtDatosProducto.Visible = false;
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No se encontro el producto";
            }
        }
    }
}
