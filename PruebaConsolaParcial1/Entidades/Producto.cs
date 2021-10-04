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




    }
}
