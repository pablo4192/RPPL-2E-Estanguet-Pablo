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
            set { if (string.IsNullOrEmpty(value)) nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { if (string.IsNullOrEmpty(value)) apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { if (value > 20000000 && value < 70000000) dni = value; }
        }

        //Metodos Clientes
        public virtual bool AltaCliente(string nombre, string apellido, string cuit, bool poseeCuenta, string saldo)
        {
            Cliente nuevoCliente;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(cuit))
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

        public virtual bool EliminarCliente(string key)
        {
            int keyInt;

            if (int.TryParse(key, out keyInt))
            {
                return Comercio.ListaClientes.Remove(keyInt);
            }
            return false;
        }

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


        public abstract string DatosEmpleadoToString(int key);

        

    }
}
