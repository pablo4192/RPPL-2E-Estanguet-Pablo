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
    public partial class FrmFacturacionTotal : FrmBase
    {
        List<Venta> listaDelMes;

        public FrmFacturacionTotal()
        {
            InitializeComponent();
            listaDelMes = new List<Venta>();
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double facturacion;

            listaDelMes = Comercio.CalcularFacturacionMes(txtMes.Text, out facturacion);

            if(listaDelMes == null)
            {
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "Hubo un problema, verifique datos ingresados";
                dgvListaVentasDelMes.DataSource = null;
            }
            else if(facturacion == 0)
            {
                dgvListaVentasDelMes.DataSource = null;
                lblAviso.Visible = true;
                lblAviso.ForeColor = Color.Violet;
                lblAviso.Text = "No hubo ventas en el mes seleccionado";
            }
            else
            {
                lblAviso.Visible = false;
                lblMonto.Visible = true;
                lblMonto.ForeColor = Color.DarkSlateBlue;
                lblMonto.Text = facturacion.ToString();
                dgvListaVentasDelMes.DataSource = listaDelMes;
                dgvListaVentasDelMes.Columns.RemoveAt(1);
            }

            


        }
    }
}
