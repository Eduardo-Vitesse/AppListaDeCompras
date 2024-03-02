namespace AppListaDeCompras.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string QuantityUnitMeasure { get; set; } // TODO - Trocar para enum
    public double Price { get; set; }
}
