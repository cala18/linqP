using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqP.guia
{
    public class guia
    {
        using System;
using System.Collections.Generic;

class Program
{
    static List<Producto> inventario = new List<Producto>();
    static List<Cliente> clientes = new List<Cliente>();
    static List<Factura> facturas = new List<Factura>();
    static List<DetalleFact> detalles = new List<DetalleFact>();

    static void Main(string[] args)
    {
        // Aquí puedes agregar datos de ejemplo al inventario, clientes, facturas y detalles.
        // Luego, implementa un menú para que el usuario realice las consultas deseadas.
    }

    // Implementa los métodos para realizar las consultas requeridas
    static void ListarProductos()
    {
        // Implementa la lógica para listar los productos en el inventario.
    }

    static void ListarProductosAgotarse()
    {
        // Implementa la lógica para listar los productos a punto de agotarse.
    }

    static void ListarProductosAComprar()
    {
        // Implementa la lógica para listar los productos que se deben comprar y la cantidad a comprar.
    }

    static void ListarFacturasEnero2023()
    {
        // Implementa la lógica para listar las facturas del mes de enero de 2023.
    }

    static void ListarProductosEnFactura(int numeroFactura)
    {
        // Implementa la lógica para listar los productos vendidos en una factura específica.
    }

    static void CalcularValorTotalInventario()
    {
        // Implementa la lógica para calcular el valor total del inventario.
    }
}

class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public decimal PrecioUnit { get; set; }
    public int Cantidad { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set;
}

class Cliente
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set;
}

class Factura
{
    public int NumeroFactura { get; set; }
    public DateTime Fecha { get; set; }
    public int IDCliente { get; set; }
    public decimal TotalFactura { get; set; }
}

class DetalleFact
{
    public int ID { get; set; }
    public int NumeroFactura { get; set; }
    public int IDProducto { get; set; }
    public int Cantidad { get; set; }
    public decimal Valor { get; set;
}

    }
}

using System;
using System.Collections.Generic;

class Program
{
    static List<Producto> inventario = new List<Producto>();
    static List<Cliente> clientes = new List<Cliente>();
    static List<Factura> facturas = new List<Factura>();
    static List<DetalleFact> detalles = new List<DetalleFact>();

    static void Main(string[] args)
    {
        // Agregar datos de ejemplo al inventario
        inventario.Add(new Producto { ID = 1, Nombre = "Martillo", PrecioUnit = 10.0m, Cantidad = 50, StockMin = 10, StockMax = 100 });
        inventario.Add(new Producto { ID = 2, Nombre = "Destornillador", PrecioUnit = 5.0m, Cantidad = 30, StockMin = 10, StockMax = 50 });
        
        // Agregar datos de ejemplo de clientes
        clientes.Add(new Cliente { ID = 1, Nombre = "Cliente1", Email = "cliente1@example.com" });
        clientes.Add(new Cliente { ID = 2, Nombre = "Cliente2", Email = "cliente2@example.com" });

        // Agregar datos de ejemplo de facturas
        facturas.Add(new Factura { NumeroFactura = 1, Fecha = DateTime.Parse("2023-01-15"), IDCliente = 1, TotalFactura = 150.0m });
        facturas.Add(new Factura { NumeroFactura = 2, Fecha = DateTime.Parse("2023-01-20"), IDCliente = 2, TotalFactura = 75.0m });

        // Agregar datos de ejemplo de detalles de facturas
        detalles.Add(new DetalleFact { ID = 1, NumeroFactura = 1, IDProducto = 1, Cantidad = 5, Valor = 50.0m });
        detalles.Add(new DetalleFact { ID = 2, NumeroFactura = 1, IDProducto = 2, Cantidad = 10, Valor = 50.0m });

        // Implementar un menú para que el usuario seleccione la consulta
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Listar productos del inventario");
            Console.WriteLine("2. Listar productos a punto de agotarse");
            Console.WriteLine("3. Listar productos a comprar y cantidad a comprar");
            Console.WriteLine("4. Listar total de facturas de enero 2023");
            Console.WriteLine("5. Listar productos vendidos en una factura");
            Console.WriteLine("6. Calcular el valor total del inventario");
            Console.WriteLine("0. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ListarProductos();
                    break;
                case "2":
                    ListarProductosAgotarse();
                    break;
                case "3":
                    ListarProductosAComprar();
                    break;
                case "4":
                    ListarFacturasEnero2023();
                    break;
                case "5":
                    Console.WriteLine("Ingrese el número de factura:");
                    if (int.TryParse(Console.ReadLine(), out int numeroFactura))
                    {
                        ListarProductosEnFactura(numeroFactura);
                    }
                    else
                    {
                        Console.WriteLine("Número de factura inválido.");
                    }
                    break;
                case "6":
                    CalcularValorTotalInventario();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    // Resto de los métodos (ListarProductos, ListarProductosAgotarse, etc.) aquí.
}
