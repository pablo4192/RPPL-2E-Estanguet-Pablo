using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        int numeroCompra;
        List<Producto> productos;
        int cliente;
        string vendedor;
        DateTime fechaCompra;
        float importe;

        static int proximoNumeroCompra;

        static Ventas()
        {
            proximoNumeroCompra = 0;
        }

        public Ventas()
        {
            proximoNumeroCompra++;
            this.numeroCompra = proximoNumeroCompra;
        }

        public Ventas(List<Producto> productos, int numCliente, string usuarioEmpleado, DateTime fechaCompra, float importe):this()
        {
            this.productos = productos;
            this.cliente = numCliente;
            this.vendedor = usuarioEmpleado;
            this.fechaCompra = fechaCompra;
            this.importe = importe;
        }

        public List<Producto> Productos
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


    }
}
