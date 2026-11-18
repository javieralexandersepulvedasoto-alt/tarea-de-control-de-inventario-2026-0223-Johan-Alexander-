using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE CONTROL DE INVENTARIO - TECNOPUNTO ===");

        // Creamos variables separadas para los 3 productos (Cumpliendo restricción: sin arreglos ni colecciones)
        Producto prod1 = null;
        Producto prod2 = null;
        Producto prod3 = null;

        // ----------------- REGISTRO PRODUCTO 1 -----------------
        Console.WriteLine("\n--- Registro del Producto 1 ---");
        while (prod1 == null)
        {
            try
            {
                Console.Write("Ingrese el código: ");
                string cod = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                decimal pre = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                int cant = int.Parse(Console.ReadLine());

                prod1 = new Producto(cod, nom, pre, cant);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex.Message} Por favor, intente de nuevo.");
            }
        }

        // ----------------- REGISTRO PRODUCTO 2 -----------------
        Console.WriteLine("\n--- Registro del Producto 2 ---");
        while (prod2 == null)
        {
            try
            {
                Console.Write("Ingrese el código: ");
                string cod = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                decimal pre = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                int cant = int.Parse(Console.ReadLine());

                prod2 = new Producto(cod, nom, pre, cant);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex.Message} Por favor, intente de nuevo.");
            }
        }

        // ----------------- REGISTRO PRODUCTO 3 -----------------
        Console.WriteLine("\n--- Registro del Producto 3 ---");
        while (prod3 == null)
        {
            try
            {
                Console.Write("Ingrese el código: ");
                string cod = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                decimal pre = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                int cant = int.Parse(Console.ReadLine());

                prod3 = new Producto(cod, nom, pre, cant);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex.Message} Por favor, intente de nuevo.");
            }
        }

        // ----------------- MOSTRAR RESULTADOS -----------------
        Console.WriteLine("\n\n========================================");
        Console.WriteLine("     INVENTARIO REGISTRADO EXITOSAMENTE");
        Console.WriteLine("========================================");

        prod1.MostrarInfo();
        prod2.MostrarInfo();
        prod3.MostrarInfo();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}