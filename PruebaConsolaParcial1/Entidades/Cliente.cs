using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        string apellido;
        string cuit;
        int numeroCliente;
        bool poseeCuenta;
        float saldo; 

        static int ultimoNumeroCliente;

        static Cliente()
        {
            ultimoNumeroCliente = 0;
        }

        private Cliente()
        {
            ultimoNumeroCliente++;
            numeroCliente = ultimoNumeroCliente;
            this.poseeCuenta = false; 
            this.saldo = 0;
        }

        public Cliente(string nombre, string apellido, string cuit): this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuit = cuit;
            
        }

        public Cliente(string nombre, string apellido, string cuit, int numeroCliente, bool poseeCuenta, float saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuit = cuit;
            this.numeroCliente = numeroCliente;
            this.poseeCuenta = false;
            this.saldo = saldo;

        }

        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                if(!string.IsNullOrEmpty(nombre))
                {
                    nombre = value;
                }
                    
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set 
            {
                if(!string.IsNullOrEmpty(apellido))
                {
                    apellido = value;
                }
                
            }
        }

        public string Cuit
        {
            get { return cuit; }
            set 
            { 
                if(!string.IsNullOrEmpty(cuit))
                {
                    cuit = value;
                }
                
            }
        }

        public int NumeroCliente
        {
            get { return numeroCliente; }
        }

        public bool PoseeCuenta
        {
            get { return poseeCuenta; }
            set 
            { 
                poseeCuenta = value; 
            }
        }

        public float Saldo
        {
            get { return saldo; }
            set 
            { 
                if(value > -1)
                {
                    saldo = value;
                }
                
            }
        }

        /// <summary>
        /// Arma un string con los datos del cliente.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>String con los datos del cliente.</returns>
        public static string DatosClienteToString(int key)
        {
            return $"{Comercio.ListaClientes[key].Nombre} {Comercio.ListaClientes[key].Apellido}, Cuit: {Comercio.ListaClientes[key].Cuit}, Posee Cuenta: {Comercio.ListaClientes[key].PoseeCuenta}, Saldo: {Comercio.ListaClientes[key].Saldo}";
        }

        



    }
}
