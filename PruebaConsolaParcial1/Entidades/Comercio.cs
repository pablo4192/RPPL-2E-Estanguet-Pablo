using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio 
    {
        static string nombre;               
        static Dictionary<int, Empleado> listaEmpleados;
        static Dictionary<int, Cliente> listaClientes;
        static List<Producto> listaProductos;
        static List<Venta> listaVentas;
     
        static Comercio()
        {
            nombre = "Cachogos";
            listaEmpleados = new Dictionary<int, Empleado>();
            listaClientes = new Dictionary<int, Cliente>();
            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();

            Hardcodeo hardcodeo = new Hardcodeo();
            hardcodeo.HardcodearEmpleados();
            hardcodeo.HardcodearClientes();
            hardcodeo.HardcodearProductos();
            hardcodeo.CargarPilasProducto();
            hardcodeo.CrearVentas();
        }

        
        public static string Nombre
        {
            get { return nombre; }
            set { if(!string.IsNullOrEmpty(value)) nombre = value; }
        }

        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
            
            
        }

        public static Dictionary<int, Cliente> ListaClientes
        {
            get { return listaClientes; }
        }

        public static Dictionary<int, Empleado> ListaEmpleados
        {
            get { return listaEmpleados; }
            
        }

        public static List<Venta> ListaVentas
        {
            get { return listaVentas; }
            
        }


        public static void AgregarEmpleado(Empleado unEmpleado)
        {
            listaEmpleados.Add(unEmpleado.Legajo, unEmpleado);
            
        }

        public static void AgregarCliente(Cliente unCliente)
        {
            listaClientes.Add(unCliente.NumeroCliente, unCliente);
        }

        public static void AgregarProducto(Producto unProducto)
        {
            listaProductos.Add(unProducto);
        }

        public static void Loguearse(string usuario, string contrasenia)
        {
            bool flag = false;

            foreach (KeyValuePair<int, Empleado> item in listaEmpleados)
            {
                if (item.Key.ToString() == contrasenia.Trim() && item.Value.Usuario == usuario.Trim())
                {
                    flag = true;
                }
            }
            
            if(!flag)
            {
                UsuarioInvalidoException usuarioInvalidoExcepcion = new UsuarioInvalidoException();
                throw usuarioInvalidoExcepcion;
            }
            
            
           
        }
            
        public static bool ValidarProducto(string nombre, string marca, string cantidad, string categoria, string precio)
        {
            float precioFloat;
            int cantidadInt;
            
            if (float.TryParse(precio, out precioFloat) && 
                int.TryParse(cantidad, out cantidadInt) &&
                !string.IsNullOrEmpty(nombre) && 
                !string.IsNullOrEmpty(marca) && 
                !string.IsNullOrEmpty(categoria) &&
                precioFloat > 0 &&
                cantidadInt > 0)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarCliente(string nombre, string apellido, string cuit, bool poseeCuenta, string saldo)
        {
            float saldoFloat;

            if (!string.IsNullOrEmpty(nombre) &&
               !string.IsNullOrEmpty(apellido) &&
               !string.IsNullOrEmpty(cuit) &&
               float.TryParse(saldo, out saldoFloat)
               )
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!char.IsLetter(nombre[i]))
                    {
                        return false;
                    }
                }
                for (int i = 0; i < apellido.Length; i++)
                {
                    if (!char.IsLetter(apellido[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
        
        public static Producto BuscarProducto(string codProducto)
        {
            int codInt;

            if(int.TryParse(codProducto, out codInt))
            {
                for(int i=0; i<listaProductos.Count; i++)
                {
                    if(listaProductos[i].CodigoProd == codInt)
                    {
                        return listaProductos[i];
                    }
                }
            }

            return null;
        }

        public static bool VerificarAdministrador(string usuario)
        {
            if(!string.IsNullOrEmpty(usuario))
            {
                foreach (KeyValuePair<int, Empleado> item in listaEmpleados)
                {
                    if(item.Value.GetType() == typeof(Administrador))
                    {
                        if(item.Value.Usuario == usuario)
                        {
                            return true;
                        }
                        
                    }
                }
            }
            return false;
        }

        public static Empleado BuscarEmpleado(string key)
        {
            int keyInt;
            
            if(int.TryParse(key, out keyInt))
            {
                if(listaEmpleados.ContainsKey(keyInt))
                {
                    return listaEmpleados[keyInt];
                }
            }
            return null;
        }

        public static Cliente BuscarCliente(string key)
        {
            int keyInt;

            if (int.TryParse(key, out keyInt))
            {
                if (listaClientes.ContainsKey(keyInt))
                {
                    return listaClientes[keyInt];
                }
            }
            return null;
        }

        public static bool ValidarEmpleado(string nombre, string apellido, string dni, string usuario, string sueldo)
        {
            int dniInt;
            float sueldoFloat;
            
            

            if(!string.IsNullOrEmpty(nombre) &&
               !string.IsNullOrEmpty(apellido) &&
               int.TryParse(dni, out dniInt) &&
               !string.IsNullOrEmpty(usuario) &&
               float.TryParse(sueldo, out sueldoFloat))
            {
                for(int i =0; i<nombre.Length; i++)
                {
                    if ( !char.IsLetter(nombre[i]) )
                    {
                        return false;
                    }
                }
                for (int i = 0; i < apellido.Length; i++)
                {
                    if (!char.IsLetter(apellido[i]))
                    {
                        return false;
                    }
                }

                return true;
            }


            return false;
        }

        public static float CalcularImporte(Producto unProducto)
        {
            float importeTotal = 0;


            importeTotal = unProducto.Cantidad * unProducto.Precio;
            

            return importeTotal;
        }

        public static bool ValidarDatosVenta(string numeroCliente, string codigoProducto, string cantidad)
        {
            int cantidadInt;
            int numeroClienteInt;
            int codigoProductoInt;

            if(int.TryParse(numeroCliente, out numeroClienteInt) &&
                int.TryParse(codigoProducto, out codigoProductoInt) &&
                int.TryParse(cantidad, out cantidadInt) )
            {
                return true;
            }

            return false;
        }

        public static bool VerificarStockProducto(Producto unProducto, int cantidad)
        {
            foreach (Producto item in listaProductos)
            {
                if(item.CodigoProd == unProducto.CodigoProd)
                {
                    if(item.Cantidad >= cantidad)
                    {
                        item.Cantidad -= cantidad;

                        return true;
                    }
                }
            }
                
            return false;
        }

        public static bool ActualizarProducto(Producto unProducto)
        {
            foreach (Producto item in listaProductos)
            {
                if(item.CodigoProd == unProducto.CodigoProd)
                {
                    item.Cantidad += unProducto.Cantidad;
                    return true;
                }
            }

            return false;
        }
       
        public static List<Venta> BuscarVentasPorCliente(string numeroCliente)
        {
            int numeroClienteInt;
            bool flag = false;
            List<Venta> auxListaVentas;

            if(int.TryParse(numeroCliente, out numeroClienteInt))
            {
                auxListaVentas = new List<Venta>();

                foreach (Venta item in listaVentas)
                {
                    if(item.Cliente == numeroClienteInt)
                    {
                        auxListaVentas.Add(item);
                        flag = true;
                    }
                }
                if(flag)
                {
                    return auxListaVentas;
                }
                

            }
            return null;
            
            
        }

        public static List<Venta> CalcularFacturacionMes(string mes, out double facturacion)
        {
            int mesInt;
            facturacion = 0;
            List<Venta> listaDelMes = new List<Venta>();

            if(int.TryParse(mes, out mesInt))
            {
                foreach (Venta item in listaVentas)
                {
                    if (item.FechaCompra.Month == mesInt)
                    {
                        facturacion += item.Importe;
                        listaDelMes.Add(item);
                        
                    }
                }
                
                return listaDelMes;
            }
            
            return null;

        }

        
        public static bool ValidarVenta(string numeroCliente, string importe)
        {
            float importeFloat;

            if(float.TryParse(importe, out importeFloat) && !string.IsNullOrEmpty(numeroCliente))
            {
                if (listaClientes[int.Parse(numeroCliente)].Saldo >= importeFloat)
                {
                    listaClientes[int.Parse(numeroCliente)].Saldo -= importeFloat;
                    return true;
                }
                else
                {
                    ClienteSinDineroExcepcion clienteSinDineroExcepcion = new ClienteSinDineroExcepcion();
                    throw clienteSinDineroExcepcion;
                }
            }
            return false;
        }

        public static bool VerificarUsuario(string legajo, string usuario)
        {
            int legajoInt;

            if (int.TryParse(legajo, out legajoInt))
            {
                foreach (KeyValuePair<int, Empleado> item in Comercio.ListaEmpleados)
                {
                    if (item.Key == legajoInt && item.Value.Usuario == usuario)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        public static float CalcularEnvio(string importeCompra, int cantidadItems, out float costoEnvio)
        {
            Random kmsRandom = new Random();
            float importeCompraFloat = 0;
            float kmCamioneta = 60;
            float kmMoto = 30;
            costoEnvio = 0;


            if (float.TryParse(importeCompra, out importeCompraFloat))
            {
                if (cantidadItems > 3)
                {
                    costoEnvio = kmCamioneta * kmsRandom.Next(1, 30);
                    importeCompraFloat += costoEnvio;
                }
                else
                {
                    costoEnvio  = kmMoto * kmsRandom.Next(1, 30);
                    importeCompraFloat += costoEnvio;

                }
            }
            
            return importeCompraFloat;
        }

    }
}
