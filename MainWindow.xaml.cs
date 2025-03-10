using AllForLife;
using System.Windows;

namespace AllForLife
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductList.ItemsSource = GetProductsFromDatabase();
            UpdateItemCount();
        }

        private void UpdateItemCount()
        {
            ItemCountText.Text = $"{ProductList.Items.Count} из {GetTotalProductCount()}";
        }

        private void DiscountFilter_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateItemCount();
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            UpdateItemCount();
        }

        private void ProductList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
        }

        private int GetTotalProductCount()
        {

            return 100; 
        }
    }
}