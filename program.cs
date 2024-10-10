using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var inventario = new Inventario();
        var clientes = new List<Cliente>(); // Cargar clientes desde archivo o inicializar vacía
        var facturas = new List<Factura>(); // Cargar facturas desde archivo o inicializar vacía

        var menuAdmin = new MenuAdmin(inventario, clientes, facturas);
        
        while (true)
        {
            menuAdmin.MostrarMenu();
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                menuAdmin.EjecutarOpcion(opcion);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
        }
    }
}
