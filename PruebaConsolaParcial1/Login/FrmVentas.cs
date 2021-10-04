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
    public partial class FrmVentas : Form
    {
        
        List<Producto> auxListaProductos;
        Ventas nuevaVenta;
        string numeroCliente;
        string codigoProducto;
        string cantidad;
        float importe;
        Producto ultimoProductoCarrito;

        private FrmVentas()
        {
            InitializeComponent();
            
        }

        public FrmVentas(string usuario): this()
        {
            lblUsuario.Text = usuario;
            auxListaProductos = new List<Producto>();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            lblAviso.Visible = true;

            if (auxListaProductos.Count > 0)
            {
                nuevaVenta = new Ventas(auxListaProductos, int.Parse(numeroCliente), lblUsuario.Text, DateTime.Now, importe);
                Comercio.ListaVentas.Add(nuevaVenta);
                txtNumeroCliente.Enabled = true;
                lblAviso.ForeColor = Color.Green;
                lblAviso.Text = "Venta exitosa!";
                auxListaProductos.Clear();
                Limpiar();
            }
            else
            {
                
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No hay productos en el carrito";
            }
                

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            numeroCliente = txtNumeroCliente.Text;
            codigoProducto = txtCodigoProd.Text;
            cantidad = txtCantidad.Text;
            Producto auxProducto;
            Cliente auxCliente;
            
            
            
            if (Comercio.ValidarDatosVenta(numeroCliente, codigoProducto, cantidad))
            {
                auxProducto = Comercio.BuscarProducto(codigoProducto); 
                auxCliente = Comercio.BuscarCliente(numeroCliente);
                if(auxProducto != null && auxCliente != null)
                {
                    if(Comercio.VerificarStockProducto(auxProducto, int.Parse(txtCantidad.Text)))
                    {
                        auxProducto.Cantidad = int.Parse(txtCantidad.Text);
                        auxListaProductos.Add(auxProducto); 
                        dgvListaCompra.DataSource = null;
                        dgvListaCompra.DataSource = auxListaProductos;
                        txtNumeroCliente.Enabled = false;
                        lblAviso.Visible = false;
                        lblDatosCliente.Visible = true;
                        lblDatosCliente.Text = Comercio.DatosClienteToString(int.Parse(numeroCliente));
                        ultimoProductoCarrito = auxProducto;
                        importe += Comercio.CalcularImporte(auxProducto); 
                        txtImporte.Text = importe.ToString();
                    }
                    else
                    {
                        lblAviso.Visible = true;
                        lblAviso.ForeColor = Color.Red;
                        lblAviso.Text = "No fue posible cargar el producto al carrito, No hay suficiente stock";
                    }
                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "No fue posible cargar el producto al carrito, no existe producto";
                }
            }
            else
            {
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No fue posible cargar el producto al carrito, verifique datos ingresados";
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(auxListaProductos.Count > 1)
            {
                auxListaProductos.Remove(ultimoProductoCarrito);
                dgvListaCompra.DataSource = null;
                dgvListaCompra.DataSource = auxListaProductos;
                importe -= ultimoProductoCarrito.Precio;
                txtImporte.Text = importe.ToString();
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal(lblUsuario.Text);
            menu.Show();
            this.Hide();
        }

        public void Limpiar()
        {
            txtNumeroCliente.Text = string.Empty;
            txtCodigoProd.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtImporte.Text = string.Empty;
            lblDatosCliente.Text = string.Empty;
            lblDatosCliente.Visible = false;
            
            dgvListaCompra.DataSource = null;
        }
    }
}
