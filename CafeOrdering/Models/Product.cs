using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeOrdering.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int WeightGrammes { get; set; }

    [NotMapped]
    public string Weight => WeightGrammes + "г.";

    public int Price { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    public Product()
    {
    }

    public Product(int id, string name, string description, int weightGrammes, int price)
        : this(name, description, weightGrammes, price)
    {
        Id = id;
    }
    
    public Product(string name, string description, int weightGrammes, int price)
        : this()
    {
        Name = name;
        Description = description;
        WeightGrammes = weightGrammes;
        Price = price;
    }
}