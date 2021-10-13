using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int numeroCompra;
        Stack<Producto> productos;
        int cliente;
        string vendedor;
        DateTime fechaCompra;
        float importe;

        static int proximoNumeroCompra;

        static Venta()
        {
            proximoNumeroCompra = 0;
        }

        private Venta()
        {
            proximoNumeroCompra++;
            this.numeroCompra = proximoNumeroCompra;
        }

        public Venta(Stack<Producto> productos, int numCliente, string usuarioEmpleado, DateTime fechaCompra, float importe):this()
        {
            this.productos = productos;
            this.cliente = numCliente;
            this.vendedor = usuarioEmpleado;
            this.fechaCompra = fechaCompra;
            this.importe = importe;
        }

        

        public int NumeroCompra
        {
            get { return numeroCompra; }
            
        }


        public Stack<Producto> Productos
        {
            get { return productos; }
        }
        public int Cliente
        {
            get { return cliente; }
        }
        public string Vendedor
        {
            get { return vendedor; }
        }
        public DateTime FechaCompra
        {
            get { return fechaCompra; }
        }
        public float Importe
        {
            get { return importe; }
        }

        public static explicit operator List<Producto> (Venta unaVenta)
        {
            List<Producto> listaProductos = unaVenta.productos.ToList();

            return listaProductos;
        }


    }
}
