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
    public partial class FrmMetodoDePago : FrmBase
    {
        string importe;
        int cantidadItems;
        bool conEnvio = false;
        float costoEnvio;
        float importeTotal;

        public float ImporteTotal
        {
            get { return importeTotal; }
        }

        public FrmMetodoDePago(string importe, int cantidadItems, bool conEnvio)
        {
            InitializeComponent();
            
            this.importe = importe;
            this.cantidadItems = cantidadItems;
            this.conEnvio = conEnvio;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(chkEfectivo.Checked || chkCuentaCorriente.Checked)
            {
                if (chkEfectivo.Checked)
                {
                    DialogResult = DialogResult.No;
                }
                else
                {
                    DialogResult = DialogResult.Yes;

                }
                this.Close();
            }
           
        }

        private void FrmMetodoDePago_Load(object sender, EventArgs e)
        {
            if(!conEnvio)
            {
                costoEnvio = 0;
                txtCostoEnvio.Text = costoEnvio.ToString();
                importeTotal = float.Parse(importe);
                txtImporteTotal.Text = importe;
            }
            else
            {
                if(cantidadItems > 0)
                {
                    importeTotal = Comercio.CalcularEnvio(importe, cantidadItems, out costoEnvio);

                    if(cantidadItems > 3)
                    {
                        lblCostoEnvio.Text += " MiniFlete";
                    }
                    else
                    {
                        lblCostoEnvio.Text += " Moto";
                    }

                    txtCostoEnvio.Text = costoEnvio.ToString();
                    txtImporteTotal.Text = importeTotal.ToString();
                }
                
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
