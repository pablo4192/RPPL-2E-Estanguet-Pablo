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
    public partial class FrmModicarProducto : Form
    {
        Usuario auxEmpleado;
        Producto prodAModificar;

        private FrmModicarProducto()
        {
            InitializeComponent();
            auxEmpleado = new Empleado();
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\iconoPerro.ico");
            this.Icon = icono;
        }

        public FrmModicarProducto(string usuario): this()
        {
            lblUsuario.Text = usuario;
        }

        private void FrmModicarProducto_Load(object sender, EventArgs e)
        {
            dgvListaProductos.DataSource = Comercio.ListaProductos;
            this.cmbCategoria.DataSource = Enum.GetValues(typeof(Ecategoria));

        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodAModificar = (Producto) dgvListaProductos.CurrentRow.DataBoundItem;
            lblAviso.Visible = false;

            txtNombre.Text = prodAModificar.Nombre;
            txtMarca.Text = prodAModificar.Marca;
            txtCantidad.Text = prodAModificar.Cantidad.ToString();
            cmbCategoria.Text = prodAModificar.Categoria;
            txtPrecio.Text = prodAModificar.Precio.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < Comercio.ListaProductos.Count; i++)
            {
                if (Comercio.ListaProductos[i].CodigoProd.ToString() == txtBuscar.Text)
                {
                    txtNombre.Text = Comercio.ListaProductos[i].Nombre;
                    txtMarca.Text = Comercio.ListaProductos[i].Marca;
                    txtCantidad.Text = Comercio.ListaProductos[i].Cantidad.ToString();
                    cmbCategoria.Text = Comercio.ListaProductos[i].Categoria;
                    txtPrecio.Text = Comercio.ListaProductos[i].Precio.ToString();
                    
                    prodAModificar = Comercio.ListaProductos[i];
                    dgvListaProductos.CurrentCell.Selected = false;
                    dgvListaProductos.Rows[i].Selected = true;
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                prodAModificar = null;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No se encontro";
                lblAviso.Visible = true;
                Limpiar();
            }
            else
            {
                lblAviso.Visible = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ModificarProducto(prodAModificar))
            {
                MessageBox.Show("No fue posible modificar el producto, verifique los datos ingresados (sin campos vacios).");
            } 
            else
            {
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Green;
                lblAviso.Text = "Producto Modificado";
            }
        }


        private bool ModificarProducto(Producto unProducto)
        {
            
            if(unProducto != null)
            {
                if (Comercio.ValidarProducto(txtNombre.Text, txtMarca.Text, txtCantidad.Text, cmbCategoria.SelectedItem.ToString(), txtPrecio.Text))
                {
                     prodAModificar.Nombre = txtNombre.Text;
                     prodAModificar.Marca = txtMarca.Text;
                     prodAModificar.Cantidad = int.Parse(txtCantidad.Text) ;
                     prodAModificar.Categoria = cmbCategoria.SelectedItem.ToString();
                     prodAModificar.Precio = float.Parse(txtPrecio.Text);

                     auxEmpleado.ModificarProducto(prodAModificar);

                     dgvListaProductos.DataSource = null;
                     dgvListaProductos.DataSource = Comercio.ListaProductos;
                     Limpiar();
                     return true;
                }

            }
               
            return false;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProducto = new FrmProductos(lblUsuario.Text);
            frmProducto.Show();
            this.Hide();
        }

        private void Limpiar()
        {
            txtBuscar.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            cmbCategoria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        
    }
}
