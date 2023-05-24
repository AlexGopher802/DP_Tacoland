using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CafeOrdering.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeOrdering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DatabaseContext _context;
        private IList<ProductCart> _productsCart;

        private int _cartSum => _productsCart.Sum(x => x.Sum);

        public MainWindow()
        {
            InitializeComponent();
            _context = DatabaseContext.GetInstance();
            _productsCart = new List<ProductCart>();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            DataGridProducts.ClearValue(ItemsControl.ItemsSourceProperty);
            DataGridProducts.ItemsSource = _context.Products.ToArray();
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CmAddCart_OnClick(object sender, RoutedEventArgs e)
        {
            var product = DataGridProducts.SelectedItem as Product;
            if (product == null)
            {
                return;
            }

            var productCart = new ProductCart(product.Id, product.Name, 1, product.Price);
            var existingItem = _productsCart.FirstOrDefault(x => x.Id == product.Id);
            if (existingItem == null)
            {
                _productsCart.Add(productCart);
            }
            else
            {
                existingItem.Quantity++;
            }

            DisplayCart();
        }

        private void DisplayCart()
        {
            DataGridCart.ClearValue(ItemsControl.ItemsSourceProperty);
            DataGridCart.ItemsSource = _productsCart;
            TbCartSum.Text = $"Итого: {_cartSum}";
        }

        private void ClearCart()
        {
            _productsCart = Array.Empty<ProductCart>();
            DisplayCart();
        }

        private void CmRemoveCart_OnClick(object sender, RoutedEventArgs e)
        {
            var productCart = DataGridCart.SelectedItem as ProductCart;
            if (productCart == null)
            {
                return;
            }

            _productsCart.Remove(productCart);
            DisplayCart();
        }

        private void BtnOrder_OnClick(object sender, RoutedEventArgs e)
        {
            if (_productsCart.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста.", "Пустая корзина", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }

            var order = new Order(_cartSum);
            _context.Orders.Add(order);

            foreach (var productCart in _productsCart)
            {
                var product = _context.Products.First(x => x.Id == productCart.Id);
                _context.OrderProducts.Add(new OrderProduct(order, product, productCart.Quantity));
            }

            _context.SaveChanges();
            MessageBox.Show($"Заказ на сумму {_cartSum}руб. оформлен.\nВаш номер заказа: {order.Number}",
                "Заказ оформлен", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearCart();
        }

        private void BtnHistory_OnClick(object sender, RoutedEventArgs e)
        {
            Hide();
            new HistoryWindow() { Owner = this }.Show();
        }
    }
}