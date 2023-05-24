using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CafeOrdering.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeOrdering;

public partial class HistoryDescriptionWindow : Window
{
    private readonly DatabaseContext _context;
    private readonly int _orderId;

    public HistoryDescriptionWindow(int orderId)
    {
        InitializeComponent();
        _context = DatabaseContext.GetInstance();
        _orderId = orderId;
    }

    private void HistoryDescriptionWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        DataGridProducts.ClearValue(ItemsControl.ItemsSourceProperty);
        var orderProducts = _context.OrderProducts.Where(x => x.OrderId == _orderId)
            .Include(x => x.Order)
            .Include(x => x.Product)
            .ToArray();
        var order = orderProducts[0].Order;

        TbWelcome.Text = $"Заказ: {order.Number}";
        DataGridProducts.ItemsSource = orderProducts
            .Select(x => new ProductCart(x.ProductId, x.Product.Name, x.Quantity, x.Product.Price))
            .ToArray();
    }

    private void HistoryDescriptionWindow_OnClosed(object? sender, EventArgs e)
    {
        Owner.IsEnabled = true;
    }

    private void BtnBack_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}