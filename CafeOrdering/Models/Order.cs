using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CafeOrdering.Models;

public class Order
{
    public int Id { get; set; }

    public string Number { get; set; }

    public DateTime DateAdded { get; set; }

    [NotMapped]
    public string FormattedDateTime => DateAdded.ToString("dd.MM.yyyy HH:mm");

    public int Sum { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    public Order()
    {
        var random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";

        var firstNumber = new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
        var lastNumber = new string(Enumerable.Repeat(numbers, 3).Select(s => s[random.Next(s.Length)]).ToArray());

        Number = $"{firstNumber}-{lastNumber}";
        DateAdded = DateTime.Now;
    }

    public Order(int sum)
        : this()
    {
        Sum = sum;
    }
}