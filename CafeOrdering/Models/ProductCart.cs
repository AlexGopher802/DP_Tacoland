namespace CafeOrdering.Models;

public class ProductCart
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public int Sum => Price * Quantity;

    public ProductCart()
    {
    }

    public ProductCart(int id, string name, int quantity, int price)
        : this()
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}