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

        //Para crear un producto para agregar al carrito con el codigo correspondiente pero con otra cantidad
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
            set { nombre = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public static string DatosProductoToString(Producto unProducto)
        {
            return $"Nombre: {unProducto.Nombre}, Apellido: {unProducto.Marca}, Cantidad: {unProducto.Cantidad}, Categoria: {unProducto.Categoria}, Precio: {unProducto.Precio}";
        }

        //Sobrecarga de operadores +, -.
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
