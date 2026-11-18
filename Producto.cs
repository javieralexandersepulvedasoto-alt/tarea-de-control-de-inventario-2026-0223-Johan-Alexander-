using System;

public class Producto
{
    // Campos privados (Restricción: No se permiten variables públicas)
    private string codigo;
    private string nombre;
    private decimal precio;
    private int cantidad;

    // Propiedad Codigo
    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    // Propiedad Nombre con validación
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }
            nombre = value;
        }
    }

    // Propiedad Precio con validación (> 0)
    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor que 0.");
            }
            precio = value;
        }
    }

    // Propiedad Cantidad con validación (no negativa)
    public int Cantidad
    {
        get { return cantidad; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }
            cantidad = value;
        }
    }

    // Propiedad de solo lectura: Valor Total (Precio * Cantidad)
    public decimal ValorTotal
    {
        get { return Precio * Cantidad; }
    }

    // Constructor que recibe los datos e inicializa el objeto
    public Producto(string codigo, string nombre, decimal precio, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    // Método para mostrar la información del producto
    public void MostrarInfo()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: ${Precio:F2}");
        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Valor Total en Existencia: ${ValorTotal:F2}");
        Console.WriteLine("----------------------------------------");
    }
}