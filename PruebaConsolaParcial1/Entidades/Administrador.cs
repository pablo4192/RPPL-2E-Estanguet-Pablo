using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador: Empleado
    {
        int claveAdm;
        static int proximaClaveAdmi;

        static Administrador()
        {
            proximaClaveAdmi = 1233;
        }

        public Administrador(string nombre, string apellido, int dni, string usuario, float sueldo) : base(nombre, apellido, dni, usuario, sueldo)
        {
            proximaClaveAdmi++;
            this.claveAdm = proximaClaveAdmi;
        }

        public Administrador(): base()
        {
           this.claveAdm = 0;
        }

        public int ClaveAdm
        {
            get { return claveAdm; }
        }

        //Metodos Empleados
        public static bool AltaEmpleado(string nombre, string apellido, string dni,string usuario, string sueldo)
        {
            float sueldoFloat;
            int dniInt;
            Empleado nuevoEmpleado;

            if(Comercio.ValidarEmpleado(nombre,apellido,dni,usuario,sueldo))
            {
                dniInt = int.Parse(dni);
                sueldoFloat = float.Parse(sueldo);

                foreach (KeyValuePair<int, Empleado> item in Comercio.ListaEmpleados)
                {
                     if(item.Value.Dni == dniInt || item.Value.Usuario == usuario)
                     {
                         return false;
                     }
                }

                    nuevoEmpleado = new Empleado(nombre, apellido, dniInt,usuario, sueldoFloat);
                    Comercio.ListaEmpleados.Add(nuevoEmpleado.Legajo, nuevoEmpleado);
                    return true;
                
            }

            return false;


        }

        public static bool ModificarEmpleado(string nombre, string apellido, string dni, string usuario, string sueldo, string legajo)
        {
            Empleado empleadoAModificar;
            int legajoInt;

            if(Comercio.ValidarEmpleado(nombre, apellido, dni, usuario, sueldo) && int.TryParse(legajo, out legajoInt))
            {
                if(Comercio.ListaEmpleados.ContainsKey(legajoInt))
                {
                    empleadoAModificar = Comercio.ListaEmpleados[legajoInt];

                    empleadoAModificar.Nombre = nombre;
                    empleadoAModificar.Apellido = apellido;
                    empleadoAModificar.Dni = int.Parse(dni);
                    empleadoAModificar.Usuario = usuario;
                    empleadoAModificar.Sueldo = float.Parse(sueldo);
                    
                    return true;
                    
                }

                
            }

            return false;
        }
    
        public static bool EliminarEmpleado(string legajo)
        {
            int legajoInt;

            if(int.TryParse(legajo, out legajoInt))
            {
                if(Comercio.ListaEmpleados[legajoInt].GetType() != typeof(Administrador))
                {
                    if (Comercio.ListaEmpleados.Remove(legajoInt))
                    {
                        return true;
                    }
                }

                
            }
            return false;
        }

        //Metodo Alta Cliente heredado de usuario con modificacion en asignar cuenta corriente y saldo 
        public new bool AltaCliente(string nombre, string apellido, string cuit, bool poseeCuenta, string saldo)
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
                nuevoCliente.PoseeCuenta = poseeCuenta;
                nuevoCliente.Saldo = float.Parse(saldo);
                Comercio.ListaClientes.Add(nuevoCliente.NumeroCliente, nuevoCliente);
                return true;
            }

            return false;
        }

        public override string DatosEmpleadoToString(int key)
        {
            string datos;

            datos = base.DatosEmpleadoToString(key);
            
            return $"{datos}, Clave Adm: { ((Administrador)Comercio.ListaEmpleados[key]).ClaveAdm}";
        }

        

    }


}
