using ComputerServis.Context;
using ComputerServis.Views.Pages.Admin;
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

namespace ComputerServis.Views.Pages.Home
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var curentUser = ContextConnect.db.SignIn.FirstOrDefault(Item => Item.Username == txbUsername.Text &&
                Item.Password == psbPassword.Password);
                if (curentUser == null)
                {
                    MessageBox.Show("Вы ввели непрвильные данные! повторите попытку пожалуйста", "Не верно", MessageBoxButton.OK, 
                        MessageBoxImage.Exclamation);
                }
                else
                {
                    switch (curentUser.IDRole)
                    {
                        case "A":
                            MessageBox.Show("Здравствуйте Админ", "ComputerServis", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            NavigationService.Navigate(new AdminEditPage());
                            break;
                        case "U":
                            MessageBox.Show("Здравствуйте Админ", "ComputerServis", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            break;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + "Выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
               
            }
        }

        private void Grid_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
