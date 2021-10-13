using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Usuario
    {
        string usuario;
        int legajo;
        float sueldo;

        static int UltimoLegajo;
        
        static Empleado()
        {
            UltimoLegajo = 1000;
        }
        private Empleado(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            UltimoLegajo++;
            this.legajo = UltimoLegajo;
        }

        public Empleado(string nombre, string apellido, int dni, string usuario, float sueldo): this(nombre, apellido, dni)
        {
            this.usuario = usuario;
            this.sueldo = sueldo;
            
        }
        
        //Constructor para crear empleados que no tengan legajo auto incremental y no me varie la cantidad de empleados.
        public Empleado(): base("Por defecto", "Por defecto", 33398112)
        {
            this.usuario = "Por defecto";
            this.legajo = 0;
            this.sueldo = 1;
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

        public override string DatosEmpleadoToString(int key)
        {
            return $"Nombre: {Comercio.ListaEmpleados[key].Nombre}, Apellido: {Comercio.ListaEmpleados[key].Apellido}, Dni: {Comercio.ListaEmpleados[key].Dni}, Usuario: {Comercio.ListaEmpleados[key].Usuario}, Sueldo: {Comercio.ListaEmpleados[key].Sueldo}";
        }


    }
}
