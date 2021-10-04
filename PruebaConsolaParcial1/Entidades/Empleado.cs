using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        string nombre;
        string apellido;
        int dni;
        string usuario;
        int legajo;
        float sueldo;

        static int UltimoLegajo;
        
        static Empleado()
        {
            UltimoLegajo = 1000;
        }
        private Empleado()
        {
            UltimoLegajo++;
            this.legajo = UltimoLegajo;
        }

        public Empleado(string nombre, string apellido, int dni, string usuario, float sueldo): this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.sueldo = sueldo;
            
        }
        
        public Empleado(string nombreDefecto)
        {
            this.nombre = nombreDefecto;
            this.apellido = "Prueba";
            this.dni = 0;
            this.usuario = "prueba";
            this.sueldo = 0;
            this.legajo = 0;

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
            set { if(value >20000000 && value <70000000) dni = value; }
        }


        public string Usuario
        {
            get { return usuario; }
            set { if(string.IsNullOrEmpty(value)) usuario = value; }
        }
        
        public int Legajo
        {
            
            get 
            { 
                return legajo; 
            }
        }

        public float Sueldo
        {
            get { return sueldo; }
            
            
            set 
            {
                if(value > 0)
                sueldo = value; 
            }
        }

        public virtual bool AltaCliente(string nombre, string apellido, string cuit, bool poseeCuenta, string saldo)
        {
            Cliente nuevoCliente;

            if( !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(cuit))
            {
                foreach (KeyValuePair<int, Cliente> item in Comercio.ListaClientes)
                {
                    if( cuit == item.Value.Cuit )
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

            if(clienteMod != null)
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

        public static bool EliminarCliente(string key)
        {
            int keyInt;

            if (int.TryParse(key, out keyInt))
            {
                return  Comercio.ListaClientes.Remove(keyInt);
            }
            return false;
        }

        public virtual string DatosEmpleadoToString(int key)
        {
            return $"Nombre: {Comercio.ListaEmpleados[key].Nombre}, Apellido: {Comercio.ListaEmpleados[key].Apellido}, Dni: {Comercio.ListaEmpleados[key].Dni}, Usuario: {Comercio.ListaEmpleados[key].Usuario}, Sueldo: {Comercio.ListaEmpleados[key].Sueldo}";
        }

        
    }
}
