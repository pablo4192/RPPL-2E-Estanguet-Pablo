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
        Usuario auxEmpleado;

        private FrmAltaProducto()
        {
            InitializeComponent();
            auxEmpleado = new Empleado();
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\iconoPerro.ico");
            this.Icon = icono;
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
            if(Comercio.ValidarProducto(txtNombre.Text, txtMarca.Text, txtCantidad.Text, cmbCategoria.SelectedItem.ToString(), txtPrecio.Text))
            {
                Producto auxProducto = new Producto(txtNombre.Text, txtMarca.Text, int.Parse(txtCantidad.Text), cmbCategoria.SelectedItem.ToString(), float.Parse(txtPrecio.Text), 0);

                if (!(Comercio.ListaProductos + auxProducto)) 
                {
                    this.lblAviso.ForeColor = Color.Magenta;
                    this.lblAviso.Visible = true;
                    this.lblAviso.Text = "El producto ya existe, se actualizo en el stock";
                    this.dgvListaProductos.DataSource = null;
                    this.dgvListaProductos.DataSource = Comercio.ListaProductos;
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
            else
            {
                this.lblAviso.ForeColor = Color.Red;
                this.lblAviso.Visible = true;
                this.lblAviso.Text = "Hubo un problema al dar de alta el producto, verifique los datos ingresados.";
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
