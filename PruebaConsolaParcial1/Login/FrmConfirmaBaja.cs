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
    public partial class FrmConfirmaBaja : Form
    {
        public FrmConfirmaBaja()
        {
            InitializeComponent();
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int legajoInt;
            int claveAdmInt;
            Empleado auxEmpleado;

            if(int.TryParse(txtLegajo.Text, out legajoInt) && int.TryParse(txtClaveAdm.Text, out claveAdmInt))
            {
                if(Comercio.ListaEmpleados.ContainsKey(legajoInt))
                {
                    auxEmpleado = Comercio.ListaEmpleados[legajoInt];

                    if(claveAdmInt == ((Administrador) auxEmpleado).ClaveAdm)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }

                
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            
            
            

            


            
        }
    }
}
