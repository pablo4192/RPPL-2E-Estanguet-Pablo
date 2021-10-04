using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Hardcodeo
    {
        #region Hardcodeo de Empleados, Clientes y Productos.

        List<Producto> listaProdHardcodeada1 = new List<Producto>();
        List<Producto> listaProdHardcodeada2 = new List<Producto>();
        List<Producto> listaProdHardcodeada3 = new List<Producto>();
        List<Producto> listaProdHardcodeada4 = new List<Producto>();

        Empleado empleado1 = new Empleado("Pepe", "Saenz", 33374859, "pepe1234", 50000);
        Empleado empleado2 = new Empleado("Carla", "Duque", 30689157, "lacarli77", 55000);
        Empleado empleado3 = new Empleado("Tomas", "Gandi", 25879654, "tomito22", 53000);
        Empleado empleado4 = new Empleado("Vera", "Espinola", 314569258, "veraesp00", 47000);

        Administrador administrador1 = new Administrador("Roberto", "Ibanes", 30978123, "elrobert88", 65000, 1234);

        Cliente cliente1 = new Cliente("Andrea", "Gomes", "20-33399102-3");
        Cliente cliente2 = new Cliente("Carlos", "Araujo", "20-25095687-2");
        Cliente cliente3 = new Cliente("Alberto", "Fernundez", "20-29399102-3");
        Cliente cliente4 = new Cliente("Mauricio", "Mocri", "20-28319107-3");
        Cliente cliente5 = new Cliente("Nicolas", "Delconio", "20-30399704-3");
        Cliente cliente6 = new Cliente("Apu", "Nasagatemapila", "20-27069741-2");
        Cliente cliente7 = new Cliente("Blanca", "Cota", "20-21069101-2");
        Cliente cliente8 = new Cliente("Mariana", "Selcius", "20-30258941-3");
        Cliente cliente9 = new Cliente("Sebastian", "Estevanez", "20-31258789-3");
        Cliente cliente10 = new Cliente("Pietro", "Sorba", "20-33394568-3");
        Cliente cliente11 = new Cliente("Claudio", "Miller", "20-34399492-3");
        Cliente cliente12 = new Cliente("Pancho", "Ibanes", "20-24396145-3");

        Producto producto1 = new Producto("ProPlan", "Purina", 10, "Alimentos", 850);
        Producto producto2 = new Producto("Excelent", "Purina", 10, "Alimentos", 650);
        Producto producto3 = new Producto("Pipeta", "VetCare", 5, "Limpieza", 400);
        Producto producto4 = new Producto("Cama", "DogZzz", 3, "Accesorios", 1000);
        Producto producto5 = new Producto("Varita", "CatPlay", 15, "Juguetes", 200);
        Producto producto6 = new Producto("Hueso", "DogPlay", 10, "Juguetes", 300);
        Producto producto7 = new Producto("EcoFood", "DogChow", 8, "Alimentos", 150);
        Producto producto8 = new Producto("AntiRabic", "Pfizer", 12, "Farmacia", 990);
        Producto producto9 = new Producto("Desinflam", "Jhonson", 6, "Farmacia", 700);
        Producto producto10 = new Producto("Collar", "PetAcc", 4, "Accesorios", 850);
        Producto producto11 = new Producto("Shampoo", "VetCare", 20, "Limpieza", 400);
        Producto producto12 = new Producto("Vaselina", "Jhonson", 6, "Farmacia", 350);
        Producto producto13 = new Producto("Cucha", "PetAcc", 3, "Accesorios", 1580);
        Producto producto14 = new Producto("Correa", "PetAcc", 8, "Accesorios", 300);
        Producto producto15 = new Producto("Jabon", "VetCare", 6, "Limpieza", 150);

        

        
        
        #endregion

        public void HardcodearEmpleados()
        {
            Comercio.AgregarEmpleado(empleado1);
            Comercio.AgregarEmpleado(empleado2);
            Comercio.AgregarEmpleado(empleado3);
            Comercio.AgregarEmpleado(empleado4);
            Comercio.AgregarEmpleado(administrador1);
        }

        public void HardcodearClientes()
        {
            Comercio.AgregarCliente(cliente1);
            Comercio.AgregarCliente(cliente2);
            Comercio.AgregarCliente(cliente3);
            Comercio.AgregarCliente(cliente4);
            Comercio.AgregarCliente(cliente5);
            Comercio.AgregarCliente(cliente6);
            Comercio.AgregarCliente(cliente7);
            Comercio.AgregarCliente(cliente8);
            Comercio.AgregarCliente(cliente9);
            Comercio.AgregarCliente(cliente10);
            Comercio.AgregarCliente(cliente11);
            Comercio.AgregarCliente(cliente12);
        }

        public void HardcodearProductos()
        {
            Comercio.AgregarProducto(producto1);
            Comercio.AgregarProducto(producto2);
            Comercio.AgregarProducto(producto3);
            Comercio.AgregarProducto(producto4);
            Comercio.AgregarProducto(producto5);
            Comercio.AgregarProducto(producto6);
            Comercio.AgregarProducto(producto7);
            Comercio.AgregarProducto(producto8);
            Comercio.AgregarProducto(producto9);
            Comercio.AgregarProducto(producto10);
            Comercio.AgregarProducto(producto11);
            Comercio.AgregarProducto(producto12);
            Comercio.AgregarProducto(producto13);
            Comercio.AgregarProducto(producto14);
            Comercio.AgregarProducto(producto15);
        }

        public void CargarListasProducto()
        {
            listaProdHardcodeada1.Add(producto15);
            listaProdHardcodeada1.Add(producto12);
            listaProdHardcodeada1.Add(producto1);

            listaProdHardcodeada2.Add(producto9);
            listaProdHardcodeada2.Add(producto12);
            listaProdHardcodeada2.Add(producto10);
            listaProdHardcodeada2.Add(producto3);

            listaProdHardcodeada3.Add(producto9);
            listaProdHardcodeada3.Add(producto1);
            listaProdHardcodeada3.Add(producto7);
            listaProdHardcodeada3.Add(producto12);
            listaProdHardcodeada3.Add(producto3);
            listaProdHardcodeada3.Add(producto5);

            listaProdHardcodeada4.Add(producto8);
            listaProdHardcodeada4.Add(producto6);
            listaProdHardcodeada4.Add(producto5);
            listaProdHardcodeada4.Add(producto12);
            listaProdHardcodeada4.Add(producto9);
            listaProdHardcodeada4.Add(producto7);
            listaProdHardcodeada4.Add(producto13);
            listaProdHardcodeada4.Add(producto2);


        }

        public void CrearVentas()
        {
            Ventas venta1 = new Ventas(listaProdHardcodeada1, cliente8.NumeroCliente , empleado2.Usuario, new DateTime(2021, 5, 12), CalcularTotal(listaProdHardcodeada1));
            Ventas venta2 = new Ventas(listaProdHardcodeada2, cliente1.NumeroCliente , empleado1.Usuario, new DateTime(2021, 3, 1), CalcularTotal(listaProdHardcodeada2));
            Ventas venta3 = new Ventas(listaProdHardcodeada3, cliente6.NumeroCliente, empleado4.Usuario, new DateTime(2021, 6, 20), CalcularTotal(listaProdHardcodeada3));
            Ventas venta4 = new Ventas(listaProdHardcodeada4, cliente9.NumeroCliente, empleado1.Usuario, new DateTime(2021, 5, 15), CalcularTotal(listaProdHardcodeada4));
            Ventas venta5 = new Ventas(listaProdHardcodeada2, cliente7.NumeroCliente, empleado1.Usuario, new DateTime(2021, 2, 11), CalcularTotal(listaProdHardcodeada2));
            Ventas venta6 = new Ventas(listaProdHardcodeada4, cliente8.NumeroCliente, empleado3.Usuario, new DateTime(2021, 7, 6), CalcularTotal(listaProdHardcodeada4));
            Ventas venta7 = new Ventas(listaProdHardcodeada2, cliente6.NumeroCliente, empleado4.Usuario, new DateTime(2021, 4, 22), CalcularTotal(listaProdHardcodeada2));
            Ventas venta8 = new Ventas(listaProdHardcodeada3, cliente9.NumeroCliente, empleado2.Usuario, new DateTime(2021, 9, 12), CalcularTotal(listaProdHardcodeada3));
            Ventas venta9 = new Ventas(listaProdHardcodeada1, cliente2.NumeroCliente, empleado1.Usuario, new DateTime(2021, 7, 10), CalcularTotal(listaProdHardcodeada1));
            Ventas venta10 = new Ventas(listaProdHardcodeada1, cliente8.NumeroCliente, empleado2.Usuario, new DateTime(2021, 8, 16), CalcularTotal(listaProdHardcodeada1));
            Ventas venta11 = new Ventas(listaProdHardcodeada3, cliente7.NumeroCliente, empleado3.Usuario, new DateTime(2021, 1, 19), CalcularTotal(listaProdHardcodeada3));
            Ventas venta12 = new Ventas(listaProdHardcodeada4, cliente1.NumeroCliente, empleado4.Usuario, new DateTime(2021, 1, 9), CalcularTotal(listaProdHardcodeada4));
            Ventas venta13 = new Ventas(listaProdHardcodeada3, cliente2.NumeroCliente, empleado4.Usuario, new DateTime(2021, 10, 3), CalcularTotal(listaProdHardcodeada3));
            Ventas venta14 = new Ventas(listaProdHardcodeada1, cliente2.NumeroCliente, empleado1.Usuario, new DateTime(2021, 10, 2), CalcularTotal(listaProdHardcodeada1));
            Ventas venta15 = new Ventas(listaProdHardcodeada2, cliente3.NumeroCliente, empleado3.Usuario, new DateTime(2021, 9, 8), CalcularTotal(listaProdHardcodeada2));

            Comercio.ListaVentas.Add(venta1);
            Comercio.ListaVentas.Add(venta2);
            Comercio.ListaVentas.Add(venta3);
            Comercio.ListaVentas.Add(venta4);
            Comercio.ListaVentas.Add(venta5);
            Comercio.ListaVentas.Add(venta6);
            Comercio.ListaVentas.Add(venta7);
            Comercio.ListaVentas.Add(venta8);
            Comercio.ListaVentas.Add(venta9);
            Comercio.ListaVentas.Add(venta10);
            Comercio.ListaVentas.Add(venta11);
            Comercio.ListaVentas.Add(venta12);
            Comercio.ListaVentas.Add(venta13);
            Comercio.ListaVentas.Add(venta14);
            Comercio.ListaVentas.Add(venta15);
        }

        private float CalcularTotal(List<Producto> lista)
        {
            float importe = 0;

            foreach (Producto item in lista)
            {
                importe += item.Precio;
            }
            return importe;
        }
        

    }
}
