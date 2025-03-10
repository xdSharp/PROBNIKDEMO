using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AllForLife
{
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadBooks()
        {
            using (var context = new StoreContext())
            {
                ProductsListView.ItemsSource = context.Products.ToList();
            }
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int bookId = (int)button.Tag;

            using (var context = new StoreContext())
            {
                var order = new Order { ProductId = bookId, UserId = CurrentUser.Id, Status = "Pending" };
                context.Orders.Add(order);
                context.SaveChanges();
            }

            MessageBox.Show("Заказ оформлен.");
        }
    }
}