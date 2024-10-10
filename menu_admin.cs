using System;
using System.Collections.Generic;

public class MenuAdmin
{
    private Inventario inventario;
    private List<Cliente> clientes;
    private List<Factura> facturas;

    public MenuAdmin(Inventario inventario, List<Cliente> clientes, List<Factura> facturas)
    {
        this.inventario = inventario;
        this.clientes = clientes;
        this.facturas = facturas;
    }

    public void MostrarMenu()
    {
        Console.WriteLine("\n=== Menú Principal ===");
        Console.WriteLine("1. Agregar Cliente");
        Console.WriteLine("2. Crear Factura");
        Console.WriteLine("3. Imprimir Estado de Mesas");
        Console.WriteLine("4. Imprimir menú restaurante");
        Console.WriteLine("5. Agregar productos restaurante");
        Console.WriteLine("6. Agregar/Editar productos de la mesa");
        Console.WriteLine("7. Imprimir cuenta mesa");
        Console.WriteLine("8. Buscar productos por Id");
        Console.WriteLine("9. Editar cuenta");
        Console.WriteLine("10. Actualizar menú");
        Console.WriteLine("11. Imprimir factura con impuestos y propina");
        Console.WriteLine("12. Gestionar el inventario de los productos");
        Console.WriteLine("13. Cargar inventario desde archivo");
        Console.WriteLine("14. Guardar inventario en archivo");
        Console.WriteLine("15. Cargar facturas desde archivo");
        Console.WriteLine("16. Guardar facturas en archivo");
        Console.WriteLine("17. Leer y guardar inventario actualizado");
        Console.WriteLine("18. Mantener actualizado el inventario");
        Console.WriteLine("19. Tener archivo de clientes");
        Console.WriteLine("20. Generar Tirilla de factura por mesa");
        Console.WriteLine("21. Imprimir estado actual de las mesas y el inventario");
        Console.WriteLine("22. Imprimir cuentas pendientes por pagar");
        Console.WriteLine("23. Salir");
    }

    public void EjecutarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                AgregarCliente();
                break;
            case 2:
                CrearFactura();
                break;
            case 3:
                ImprimirEstadoMesas();
                break;
            case 4:
                ImprimirMenuRestaurante();
                break;
            case 5:
                AgregarProductoRestaurante();
                break;
            case 6:
                AgregarEditarProductosMesa();
                break;
            case 7:
                ImprimirCuentaMesa();
                break;
            case 8:
                BuscarProductoPorId();
                break;
            case 9:
                EditarCuenta();
                break;
            case 10:
                ActualizarMenu();
                break;
            case 11:
                ImprimirFacturaConImpuestos();
                break;
            case 12:
                GestionarInventarioAlRealizarVenta();
                break;
            case 13:
                CargarInventarioDesdeArchivo();
                break;
            case 14:
                GuardarInventarioEnArchivo();
                break;
            case 15:
                CargarFacturasDesdeArchivo();
                break;
            case 16:
                GuardarFacturasEnArchivo();
                break;
            case 17:
                LeerYGuardarInventarioActualizado();
                break;
            case 18:
                MantenerActualizadoInventario();
                break;
            case 19:
                TenerArchivoDeClientes();
                break;
            case 20:
                GenerarTirillaFacturaPorMesa();
                break;
            case 21:
                ImprimirEstadoMesasEInventario();
                break;
            case 22:
                ImprimirCuentasPendientes();
                break;
            case 23:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    private void AgregarCliente()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        var cliente = new Cliente { Nombre = nombre };
        clientes.Add(cliente);
        Console.WriteLine("Cliente agregado.");
    }

    private void CrearFactura()
    {
        // Lógica para crear una nueva factura
    }

    private void ImprimirEstadoMesas()
    {
        Console.WriteLine("Estado de mesas:");
        // Imprimir estado de las mesas
    }

    private void ImprimirMenuRestaurante()
    {
        Console.WriteLine("Menú del Restaurante:");
        // Implementar lógica para imprimir el menú
    }

    private void AgregarProductoRestaurante()
    {
        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad en stock: ");
        int cantidad = int.Parse(Console.ReadLine());

        var producto = new Producto { Id = id, Nombre = nombre, Precio = precio, Cantidad = cantidad };
        inventario.AgregarProducto(producto);
    }

    private void AgregarEditarProductosMesa()
    {
        // Implementar lógica para agregar/editar productos en la mesa
    }

    private void ImprimirCuentaMesa()
    {
        // Implementar lógica para imprimir la cuenta de una mesa
    }

    private void BuscarProductoPorId()
    {
        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine());
        var producto = inventario.BuscarProductoPorId(id);
        if (producto != null)
        {
            Console.WriteLine(producto);
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    private void EditarCuenta()
    {
        // Implementar lógica para editar cuenta
    }

    private void ActualizarMenu()
    {
        // Implementar lógica para actualizar el menú
    }

    private void ImprimirFacturaConImpuestos()
    {
        // Implementar lógica para imprimir la factura con impuestos y propina
    }

    private void GestionarInventarioAlRealizarVenta()
    {
        // Implementar lógica para gestionar el inventario cuando se realiza una venta
    }

    private void CargarInventarioDesdeArchivo()
    {
        // Implementar lógica para cargar el inventario desde un archivo
    }

    private void GuardarInventarioEnArchivo()
    {
        // Implementar lógica para guardar el inventario en un archivo
    }

    private void CargarFacturasDesdeArchivo()
    {
        // Implementar lógica para cargar las facturas desde un archivo
    }

    private void GuardarFacturasEnArchivo()
    {
        // Implementar lógica para guardar las facturas en un archivo
    }

    private void LeerYGuardarInventarioActualizado()
    {
        // Implementar lógica para leer y guardar el inventario actualizado
    }

    private void MantenerActualizadoInventario()
    {
        // Implementar lógica para mantener el inventario actualizado
    }

    private void TenerArchivoDeClientes()
    {
        // Implementar lógica para manejar el archivo de clientes
    }

    private void GenerarTirillaFacturaPorMesa()
    {
        // Implementar lógica para generar la tirilla de factura por mesa
    }

    private void ImprimirEstadoMesasEInventario()
    {
        // Implementar lógica para imprimir el estado actual de las mesas e inventario
    }

    private void ImprimirCuentasPendientes()
    {
        // Implementar lógica para imprimir las cuentas pendientes por pagar
    }
}
