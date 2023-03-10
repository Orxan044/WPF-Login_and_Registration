using usern;
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

namespace WPF___Login_and_Registration
{
    public partial class MainWindow : Window
    {
        User user = new User();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regestration regestration = new Regestration();
            Close();
            regestration.Show();
        }

        private void Login_yoxlama(object sender, RoutedEventArgs e)
        {
            bool control = true;

            for (int i = 0; i < user.users.Count; i++)
            {
                if (user.users[i].Name == nametextBox.ToString() && user.users[i].Password == PasswordTextBox.ToString())
                {
                    control = false;
                    MessageBox.Show("Daxil Olursuz");
                }
            }
            if (control)
            {
                MessageBox.Show("Yalnis Parol");
            }
        }
    }
}
