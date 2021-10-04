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
        static List<Ventas> listaVentas;
     
        static Comercio()
        {
            nombre = "Cachogos";
            listaEmpleados = new Dictionary<int, Empleado>();
            listaClientes = new Dictionary<int, Cliente>();
            listaProductos = new List<Producto>();
            listaVentas = new List<Ventas>();

            Hardcodeo hardcodeo = new Hardcodeo();
            hardcodeo.HardcodearEmpleados();
            hardcodeo.HardcodearClientes();
            hardcodeo.HardcodearProductos();
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

        public static List<Ventas> ListaVentas
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

        
        public static bool Loguearse(string usuario, string contrasenia)
        {
            foreach (KeyValuePair<int, Empleado> item in listaEmpleados)
            {
                if (item.Key.ToString() == contrasenia && item.Value.Usuario == usuario)
                {
                    return true;
                }
            }

            return false;
        }
            
        
        public static bool AltaProducto(string nombre, string marca, string cantidad, string categoria, string precio)
        {
            
            int cantidadInt;
            float precioFloat;
            Producto nuevoProducto;

            if (ValidarProducto(nombre, marca, cantidad, categoria, precio))
            {
                cantidadInt = int.Parse(cantidad);
                precioFloat = float.Parse(precio);

                foreach (Producto item in listaProductos)
                {
                    if(item.Nombre == nombre && item.Marca == marca)
                    {
                        item.Cantidad += cantidadInt;
                        item.Precio = precioFloat;
                        return true;
                    }
                }
                nuevoProducto = new Producto(nombre, marca, cantidadInt, categoria, precioFloat);
                AgregarProducto(nuevoProducto);
                
                return true; 
            }

            return false;
        }

        public static bool BajaProducto(string nombre, string marca, string legajo)
        {
            int legajoInt;

            if(int.TryParse(legajo, out legajoInt))
            {
                foreach (KeyValuePair<int, Empleado> item in listaEmpleados)
                {
                    if (item.Key == legajoInt)
                    {
                        foreach (Producto item2 in listaProductos)
                        {
                            if(item2.Nombre == nombre && item2.Marca == marca)
                            {
                                listaProductos.Remove(item2);
                                return true;
                            }
                        }
                    }
                    
                }
            }
            return false;
           
        }

        public static void ModificarProducto(Producto prodModificado)
        {
            Producto producto;

            foreach (Producto item in listaProductos)
            {
                if(item.CodigoProd == prodModificado.CodigoProd)
                {
                    producto = item;
                }
            }
            producto = prodModificado;
        }

        
        public static bool ValidarProducto(string nombre, string marca, string cantidad, string categoria, string precio)
        {
            float precioFloat;
            int cantidadInt;
            
            if (float.TryParse(precio, out precioFloat) && 
                int.TryParse(cantidad, out cantidadInt) &&
                !string.IsNullOrEmpty(nombre) && 
                !string.IsNullOrEmpty(marca) && 
                !string.IsNullOrEmpty(categoria))
            {
                return true;
            }
            return false;
        }

        
        public static string DatosClienteToString(int key)
        {
            
            return $"{Comercio.ListaClientes[key].Nombre} {Comercio.ListaClientes[key].Apellido}, Cuit: {Comercio.ListaClientes[key].Cuit}, Posee Cuenta: {Comercio.ListaClientes[key].PoseeCuenta}, Saldo: {Comercio.ListaClientes[key].Saldo}";
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

        public static Producto BuscarProducto(string codProducto, List<Producto> lista)
        {
            int codInt;

            if (int.TryParse(codProducto, out codInt))
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].CodigoProd == codInt)
                    {
                        return lista[i];
                    }
                }
            }

            return null;
        }


        public static string DatosProductoToString(Producto unProducto)
        {
            return $"Nombre: {unProducto.Nombre}, Apellido: {unProducto.Marca}, Cantidad: {unProducto.Cantidad}, Categoria: {unProducto.Categoria}, Precio: {unProducto.Precio}";
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



        #region Metodos Mostrar para probar en consola.
        //public static void MostrarEmpleadosEnConsola()
        //{
        //    Console.WriteLine("***Lista de Empleados***");
        //    foreach (KeyValuePair<int, Empleado> item in listaEmpleados)
        //    {
        //        if (item.Value.GetType() == typeof(Administrador))
        //        {
        //            Console.WriteLine(((Administrador)item.Value).MostrarInfoAdmi());
        //        }
        //        else
        //        {
        //            Console.WriteLine($"nombre: {item.Value.Nombre}, apellido: {item.Value.Apellido}, usuario: {item.Value.Usuario}, sueldo: {item.Value.Sueldo}");
        //        }
        //    }
        //}

        //public static void MostrarClientesEnConsola()
        //{
        //    Console.WriteLine("***Lista de Clientes***");
        //    foreach (KeyValuePair<int, Cliente> item in listaClientes)
        //    {
        //        Console.WriteLine("key: " + item.Key);
        //        Console.WriteLine($"nombre: {item.Value.Nombre}, apellido: {item.Value.Apellido}, cuit: {item.Value.Cuit}, numero cliente: {item.Value.NumeroCliente}, saldo: {item.Value.Saldo}");

        //    }
        //}

        //public static void MostrarProductos()
        //{
        //    Console.WriteLine("***Lista de productos***");
        //    foreach (Producto item in listaProductos)
        //    {
        //        Console.WriteLine($"nombre: {item.Nombre}, marca: {item.Marca}, cantidad: {item.Cantidad}, categoria: {item.Categoria}, precio: {item.Precio}");
        //    }
        //}
        #endregion















    }
}
