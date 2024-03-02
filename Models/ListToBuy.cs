namespace AppListaDeCompras.Models;

public class ListToBuy
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<User> Users { get; set; } = [];
    public List<Product> Products { get; set; } = [];
    public DateTimeOffset CreatedAt { get; set; }
}
