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
    public partial class FrmVentaPorCliente : Form
    {
        List<Venta> listaVentas;
        List<Producto> listaProductosVenta;
        Venta venta;

        private FrmVentaPorCliente()
        {
            InitializeComponent();
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\iconoPerro.ico");
            this.Icon = icono;
        }

        public FrmVentaPorCliente(List<Venta> listaVentas): this()
        {
            this.listaVentas = listaVentas; 
        }

        private void FrmVentaPorCliente_Load(object sender, EventArgs e)
        {
            this.lblDatosCliente.Text = Cliente.DatosClienteToString(listaVentas[0].Cliente);

            dgvListaVentas.DataSource = listaVentas;
            dgvListaVentas.Columns.RemoveAt(1);
        }

        private void dgvListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            venta = (Venta) dgvListaVentas.CurrentRow.DataBoundItem;

            listaProductosVenta = (List<Producto>) venta;

            dgvProductosVendidos.DataSource = listaProductosVenta;
        }
    }
}
