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
    public partial class FrmHistorialVentas : Form
    {

        List<Venta> auxListaVentas;

        public FrmHistorialVentas()
        {
            InitializeComponent();
            Icon icono = new Icon(Application.StartupPath + @"\Iconos\iconoPerro.ico");
            this.Icon = icono;
        }

        public FrmHistorialVentas(string usuario): this()
        {
            this.lblUsuario.Text = usuario;
            auxListaVentas = new List<Venta>();
        }

        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            this.dgvHistorialVentas.DataSource = Comercio.ListaVentas;
            this.dgvHistorialVentas.Columns.RemoveAt(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            auxListaVentas = Comercio.BuscarVentasPorCliente(txtBuscar.Text);

            if(auxListaVentas == null)
            {
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No se encontraron ventas realizadas con el numero de cliente ingresado";
            }
            else
            {
                FrmVentaPorCliente frmVentasPorCliente = new FrmVentaPorCliente(auxListaVentas);
                frmVentasPorCliente.ShowDialog();
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmFacturacionTotal facturacionTotal = new FrmFacturacionTotal();
            facturacionTotal.ShowDialog();
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(lblUsuario.Text);
            frmMenuPrincipal.Show();
            this.Hide();
        }
    }
}
