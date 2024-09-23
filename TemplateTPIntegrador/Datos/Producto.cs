using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public List<string> Categorias { get; set; }  // Lista para manejar múltiples categorías
    public int Stock { get; set; }
    public Proveedor Proveedor { get; set; }

    public Producto(int id, string nombre, List<string> categorias, int stock, Proveedor proveedor)
    {
        Id = id;
        Nombre = nombre;
        Categorias = categorias;
        Stock = stock;
        Proveedor = proveedor;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto: {Nombre}");
        Console.WriteLine($"Categorías: {string.Join(", ", Categorias)}");
        Console.WriteLine($"Stock: {Stock}");
        Console.WriteLine($"Proveedor: {Proveedor.Nombre}");
        Console.WriteLine();
    }

    public bool StockCritico()
    {
        return Stock < 25;  // Alerta si el stock es menor al 25%
    }
}
}
