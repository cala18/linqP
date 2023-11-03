
using linqP.Clases;

internal class Program

{
    static List<Producto> inventario = new List<Producto>();
    static List<Cliente> clientes = new List<Cliente>();
    static List<Factura> facturas = new List<Factura>();
    static List<DetalleFact> detalles = new List<DetalleFact>();

    static void Main(string[] args)
    {
        // Aquí puedes agregar datos de ejemplo al inventario, clientes, facturas y detalles.
        // Luego, implementa un menú para que el usuario realice las consultas deseadas.
        inventario.Add(new Producto { ID = 1, Nombre = "Martillo", PrecioUnit = 10.0m, Cantidad = 50, StockMin = 10, StockMax = 100 });
        inventario.Add(new Producto { ID = 2, Nombre = "caladora", PrecioUnit = 10.0m, Cantidad = 50, StockMin = 10, StockMax = 100 });
        inventario.Add(new Producto { ID = 3, Nombre = "carretilla", PrecioUnit = 10.0m, Cantidad = 50, StockMin = 10, StockMax = 100 });

        clientes.Add(new Cliente {ID =1, Nombre = "Brayan Cala", Email = "brayancala2375@gmail.com"});
        clientes.Add(new Cliente {ID =2, Nombre = "Juan David", Email = "Juancho03@gmail.com"});
        clientes.Add(new Cliente {ID =3, Nombre = "Yael Cano", Email = "YaelyElba@gmail.com"});

        facturas.Add(new Factura {numeroFactura = 1, Fecha = DateTime.Parse("2023-01-15"), IDCliente = 1, TotalFactura = 150.0m   });
        facturas.Add(new Factura {numeroFactura = 1, Fecha = DateTime.Parse("2023-01-15"), IDCliente = 1, TotalFactura = 150.0m   });
        facturas.Add(new Factura {numeroFactura = 1, Fecha = DateTime.Parse("2023-01-15"), IDCliente = 1, TotalFactura = 150.0m   });

        detalles.Add(new DetalleFact { ID = 1, NumeroFactura = 1, IDProducto = 1, Cantidad = 5, Valor = 50.0m });
        detalles.Add(new DetalleFact { ID = 2, NumeroFactura = 1, IDProducto = 2, Cantidad = 10, Valor = 50.0m });

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

