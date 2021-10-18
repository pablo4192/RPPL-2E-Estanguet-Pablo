using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        string nombre;
        string apellido;
        int dni;

        public Usuario(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { if (!string.IsNullOrEmpty(value)) nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { if (!string.IsNullOrEmpty(value)) apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { if (value > 20000000 && value < 70000000) dni = value; }
        }

        /// <summary>
        /// Modifica un producto especifico de la lista de productos del comercio.
        /// </summary>
        /// <param name="prodModificado"></param>
        public void ModificarProducto(Producto prodModificado)
        {
            Producto producto;

            foreach (Producto item in Comercio.ListaProductos)
            {
                if (item.CodigoProd == prodModificado.CodigoProd)
                {
                    producto = item;
                }
            }
            producto = prodModificado;
        }

        /// <summary>
        /// Elimina un cliente especifico de la lista de clientes del comercio.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>True si elimino al cliente, False si no logro eliminarlo.</returns>
        public bool EliminarCliente(string key)
        {
            int keyInt;

            if (int.TryParse(key, out keyInt))
            {
                return Comercio.ListaClientes.Remove(keyInt);
            }
            return false;
        }


        //Metodos virtual y abstract que se le hacen new y/o override o se implementan en clase Empleados y Administrador.

        /// <summary>
        /// Da de salta un cliente y lo agrega a la lista de clientes del comercio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuit"></param>
        /// <param name="poseeCuenta"></param>
        /// <param name="saldo"></param>
        /// <returns>True si se dio de alta el cliente, False si el cliente ya existe en la lista o si no los datos no son aptos para dar de alta al cliente.</returns>
        public virtual bool AltaCliente(string nombre, string apellido, string cuit, bool poseeCuenta, string saldo)
        {
            Cliente nuevoCliente;

            if (Comercio.ValidarCliente(nombre, apellido, cuit, poseeCuenta, saldo))
            {
                foreach (KeyValuePair<int, Cliente> item in Comercio.ListaClientes)
                {
                    if (cuit == item.Value.Cuit)
                    {
                        return false;
                    }
                }
                nuevoCliente = new Cliente(nombre, apellido, cuit);
                Comercio.ListaClientes.Add(nuevoCliente.NumeroCliente, nuevoCliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica campos de un cliente especifico.
        /// </summary>
        /// <param name="clienteMod"></param>
        /// <returns>True si se pudo modificar al cliente, False si no se pudo modificar.</returns>
        public virtual bool ModificarCliente(Cliente clienteMod)
        {
            Cliente cliente;

            if (clienteMod != null)
            {
                foreach (KeyValuePair<int, Cliente> item in Comercio.ListaClientes)
                {
                    if (clienteMod.NumeroCliente == item.Key)
                    {
                        cliente = item.Value;
                        cliente = clienteMod;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo abstracto para armar string con datos de empleados o administradores.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>String con los datos de un empleado o administrador.</returns>
        public abstract string DatosEmpleadoToString(int key);

        

    }
}
