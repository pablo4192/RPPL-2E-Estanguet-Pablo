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

        /// <summary>
        /// Agrega un Empleado a la lista de empleados del comercio
        /// </summary>
        /// <param name="unEmpleado"></param>
        public static void AgregarEmpleado(Empleado unEmpleado)
        {
            listaEmpleados.Add(unEmpleado.Legajo, unEmpleado);
            
        }
        
        /// <summary>
        /// Agrega un cliente a la lista de clientes del comercio.
        /// </summary>
        /// <param name="unCliente"></param>
        public static void AgregarCliente(Cliente unCliente)
        {
            listaClientes.Add(unCliente.NumeroCliente, unCliente);
        }

        /// <summary>
        /// Agrega un producto a la lista de productos del comercio.
        /// </summary>
        /// <param name="unProducto"></param>
        public static void AgregarProducto(Producto unProducto)
        {
            listaProductos.Add(unProducto);
        }

        /// <summary>
        /// Verifica si el usuario y contraseña ingresados pertenecen a un empleado del comercio.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
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
            
        /// <summary>
        /// Valida los datos con los que se va a instanciar un producto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="cantidad"></param>
        /// <param name="categoria"></param>
        /// <param name="precio"></param>
        /// <returns>True si los datos son aptos, false si no son aptos para crear uin producto.</returns>
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

        /// <summary>
        /// Valida los datos con los que se va a instanciar un cliente.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuit"></param>
        /// <param name="poseeCuenta"></param>
        /// <param name="saldo"></param>
        /// <returns>True si los datos son aptos, false si los datos no son aptos para crear un cliente.</returns>
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
        
        /// <summary>
        /// Busca un producto determinado en la lista de productos del comercio.
        /// </summary>
        /// <param name="codProducto"></param>
        /// <returns>El producto de la lista que coincide con el buscado, null si no se encontro el producto en la lista.</returns>
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

        /// <summary>
        /// Verifica si el usuario pasado por parametro pertenece a un administrador.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>True si el empleado es administrador, false si no lo es.</returns>
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

        /// <summary>
        /// Busca un empleado en la lista de empleados del comercio.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>El empleado de la lista que coincide con el empleado buscado, null si no se encontro el empleado en la lista.</returns>
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

        /// <summary>
        /// Busca un cliente en la lista de clientes del comercio.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>El cliente de la lista que coincide con el cliente buscado, null si no se encontro el cliente en la lista.</returns>
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

        /// <summary>
        /// Valida los datos con los que se va a instanciar un empleado.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="sueldo"></param>
        /// <returns>True si los datos son aptos para crear un empleado, false si los dastos no son aptos.</returns>
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

        /// <summary>
        /// Calcula el importe segun precio y cantidad del producto pasado por parametro.
        /// </summary>
        /// <param name="unProducto"></param>
        /// <returns>Importe resultado de la operacion precio * cantidad.</returns>
        public static float CalcularImporte(Producto unProducto)
        {
            float importeTotal = 0;


            importeTotal = unProducto.Cantidad * unProducto.Precio;
            

            return importeTotal;
        }

        /// <summary>
        /// Valida los datos con los que se va a instanciar una venta.
        /// </summary>
        /// <param name="numeroCliente"></param>
        /// <param name="codigoProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>True si los datos son aptos para crear una venta, false si los datos no son aptos.</returns>
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

        /// <summary>
        /// Verifica si el stock del producto es suficiente para hacer la venta y actualiza la cantidad del producto en la lista.
        /// </summary>
        /// <param name="unProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>True si hay stock disponible y se actualizo la cantidad, false si no hay suficiente stock.</returns>
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

        /// <summary>
        /// Actualiza la cantidad del producto eliminado del carrito de compras.
        /// </summary>
        /// <param name="unProducto"></param>
        /// <returns>True si actualizo la cantidad, false si no la actualizo.</returns>
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
       
        /// <summary>
        /// Busca las ventas de un cliente determinado en la lista de ventas del comercio.
        /// </summary>
        /// <param name="numeroCliente"></param>
        /// <returns>Lista de ventas del cliente, null si el cliente no tiene ventas.</returns>
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

        /// <summary>
        /// Calcula el importe de las ventas echas en un mes determinado.
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="facturacion"></param>
        /// <returns>Lista de ventas echas en el mes, null si no hay ventas</returns>
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

        /// <summary>
        /// Valida si el cliente tiene saldo disponible en su cuenta para realizar una compra y actualiza su saldo.
        /// </summary>
        /// <param name="numeroCliente"></param>
        /// <param name="importe"></param>
        /// <returns>True si el cliente tiene saldo suficiente, false si el saldo es insuficiente.</returns>
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

        /// <summary>
        /// Verifica si contraseña y usuario del empleado coinciden entre si con las del empleado de la lista del comercio.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="usuario"></param>
        /// <returns>True si contraseña y usuario coinciden, False si no coinciden.</returns>
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

        /// <summary>
        /// Calcula el costo del envio de un producto y el importe total de la compra.
        /// </summary>
        /// <param name="importeCompra"></param>
        /// <param name="cantidadItems"></param>
        /// <param name="costoEnvio"></param>
        /// <returns>Importe total, envio incluido, de la compra; y costo de envio en variable out.</returns>
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
