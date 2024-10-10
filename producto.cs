using System;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    public void ActualizarInventario(int cantidad)
    {
        Cantidad -= cantidad;
    }

    public override string ToString()
    {
        return $"{Id}: {Nombre} - {Precio:C} (Stock: {Cantidad})";
    }
}
