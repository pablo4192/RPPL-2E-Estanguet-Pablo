using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int codigoProd;
        string nombre;
        string marca;
        int cantidad;
        string categoria;
        float precio;

        static int ProximoCodigoProd;
        static Producto()
        {
            ProximoCodigoProd = 2000;
        }

        private Producto()
        {
            ProximoCodigoProd++;
            this.codigoProd = ProximoCodigoProd;
        }

        public Producto(string nombre, string marca, int cantidad, string categoria, float precio): this()
        {
            this.nombre = nombre;
            this.marca = marca;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.precio = precio;
        }

        public Producto(string nombre, string marca, int cantidad, string categoria, float precio, int codigoProd)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.precio = precio;
            this.codigoProd = codigoProd;
        }

        public int CodigoProd
        {
            get { return codigoProd; }     
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

        public string Marca
        {
            get { return marca; }
            set 
            { 
                if(!string.IsNullOrEmpty(marca))
                {
                    marca = value;
                }
                 
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set 
            { 
                if(cantidad > -1)
                {
                    cantidad = value;
                }
                
            }
        }

        public string Categoria
        {
            get { return categoria; }
            set 
            { 
                if(!string.IsNullOrEmpty(categoria))
                {
                    categoria = value;
                }
                
            }
        }
        
        public float Precio
        {
            get { return precio; }
            set 
            { 
                if(precio > 0)
                {
                    precio = value;
                }
                
            }
        }

        /// <summary>
        /// Arma un string con los datos de un cliente.
        /// </summary>
        /// <param name="unProducto"></param>
        /// <returns>String con los datos de un cliente.</returns>
        public static string DatosProductoToString(Producto unProducto)
        {
            return $"Nombre: {unProducto.Nombre}, Apellido: {unProducto.Marca}, Cantidad: {unProducto.Cantidad}, Categoria: {unProducto.Categoria}, Precio: {unProducto.Precio}";
        }

        //Sobrecarga de operadores +, -.

        /// <summary>
        /// Crea un producto y lo agrega a la lista de productos del comercio, si el producto ya existe se actualiza.
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="unProducto"></param>
        /// <returns>True si creo el producto y lo agrego a la lista, False si el producto ya existe.</returns>
        public static bool operator +(List<Producto> listaProductos , Producto unProducto)
        {
            Producto nuevoProducto;

            foreach (Producto item in listaProductos)
            {
                if (item.nombre == unProducto.nombre && item.marca == unProducto.marca)
                {
                    item.Cantidad += unProducto.Cantidad;
                    item.Precio = unProducto.Precio;
                    return false;
                }
            }
            nuevoProducto = new Producto(unProducto.Nombre, unProducto.Marca, unProducto.Cantidad, unProducto.Categoria, unProducto.Precio);
            Comercio.AgregarProducto(nuevoProducto);

            return true;
        }

        /// <summary>
        /// Elimina un producto de la lista de productos del comercio.
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="unProducto"></param>
        /// <returns>True si el producto fue eliminado, False si no se puedo eliminar.</returns>
        public static bool operator -(List<Producto> listaProductos, Producto unProducto)
        {
            if(listaProductos.Remove(unProducto))
            {
                return true;
            }

            return false;
        }

       



    }
}
