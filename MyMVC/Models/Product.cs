namespace MyMVC.Models;

public class Product
{
    public int Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public decimal PricePerKg { get; set; }
    public int QuantityKg { get; set; }
}
