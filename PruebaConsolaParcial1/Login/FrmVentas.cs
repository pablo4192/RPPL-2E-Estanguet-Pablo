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
        Stack<Producto> auxPilaProductos;

        Producto prodAgregado;
       
        Venta nuevaVenta;
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
            auxPilaProductos = new Stack<Producto>();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            lblAviso.Visible = true;
            FrmMetodoDePago frmMetodo = new FrmMetodoDePago();

            DialogResult retorno = frmMetodo.ShowDialog();


            if (retorno == DialogResult.Yes)
            {
                if (Comercio.ValidarVenta(numeroCliente, txtImporte.Text))
                {
                    if (auxPilaProductos.Count > 0)
                    {
                        nuevaVenta = new Venta(auxPilaProductos, int.Parse(numeroCliente), lblUsuario.Text, DateTime.Now, importe);
                        Comercio.ListaVentas.Add(nuevaVenta);
                        txtNumeroCliente.Enabled = true;
                        lblAviso.ForeColor = Color.Green;
                        lblAviso.Text = "Venta exitosa!";
                        auxPilaProductos.Clear();
                        Limpiar();
                    }
                    else
                    {

                        lblAviso.ForeColor = Color.Red;
                        lblAviso.Text = "No hay productos en el carrito";
                    }
                }
                else
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "Venta Cancelada, Saldo insuficiente";
                }
            }
            else if(retorno == DialogResult.No)
            {
                if (auxPilaProductos.Count > 0)
                {
                    nuevaVenta = new Venta(auxPilaProductos, int.Parse(numeroCliente), lblUsuario.Text, DateTime.Now, importe);
                    Comercio.ListaVentas.Add(nuevaVenta);
                    txtNumeroCliente.Enabled = true;
                    lblAviso.ForeColor = Color.Green;
                    lblAviso.Text = "Venta exitosa!";
                    auxPilaProductos.Clear();
                    Limpiar();
                }
                else
                {

                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "No hay productos en el carrito";
                }
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
                        prodAgregado = new Producto(auxProducto.Nombre, auxProducto.Marca, int.Parse(txtCantidad.Text), auxProducto.Categoria, auxProducto.Precio, auxProducto.CodigoProd);

                        
                        auxPilaProductos.Push(prodAgregado); 

                        dgvListaCompra.DataSource = null;
                        dgvListaCompra.DataSource = auxPilaProductos.ToArray();

                        txtNumeroCliente.Enabled = false;
                        lblAviso.Visible = false;
                        lblDatosCliente.Visible = true;
                        lblDatosCliente.Text = Cliente.DatosClienteToString(int.Parse(numeroCliente));
                        
                        importe += Comercio.CalcularImporte(prodAgregado); 
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
            float importeADescontar;

            if(auxPilaProductos.Count > 0)
            {
                ultimoProductoCarrito = auxPilaProductos.Peek();

                importeADescontar = Comercio.CalcularImporte(ultimoProductoCarrito);

                importe -= importeADescontar;
                txtImporte.Text = importe.ToString();

                Comercio.ActualizarProducto(ultimoProductoCarrito);

                auxPilaProductos.Pop();
                
                
                dgvListaCompra.DataSource = null;
                dgvListaCompra.DataSource = auxPilaProductos.ToArray();
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            while (auxPilaProductos.Count > 0)
            {
                ultimoProductoCarrito = auxPilaProductos.Pop();
                Comercio.ActualizarProducto(ultimoProductoCarrito);
            }
                
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
