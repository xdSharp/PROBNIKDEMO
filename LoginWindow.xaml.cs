using System.Windows;

namespace AllForLife
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;


            if (IsValidUser(username, password))
            {

                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "admin" && password == "admin"; // Пример
        }
    }
}