using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CafeOrdering.Models;

namespace CafeOrdering;

public partial class HistoryWindow : Window
{
    private readonly DatabaseContext _context;

    public HistoryWindow()
    {
        InitializeComponent();
        _context = DatabaseContext.GetInstance();
    }

    private void HistoryWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        DataGridHistory.ClearValue(ItemsControl.ItemsSourceProperty);
        DataGridHistory.ItemsSource = _context.Orders.ToArray();
    }

    private void HistoryWindow_OnClosed(object? sender, EventArgs e)
    {
        Owner.Show();
    }

    private void BtnBack_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void CmHistoryDetails_OnClick(object sender, RoutedEventArgs e)
    {
        var order = DataGridHistory.SelectedItem as Order;
        if (order == null)
        {
            return;
        }

        IsEnabled = false;
        new HistoryDescriptionWindow(order.Id) { Owner = this }.Show();
    }
}