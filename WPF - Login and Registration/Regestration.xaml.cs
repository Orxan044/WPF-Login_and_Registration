﻿using WPF___Login_and_Registration;
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
using System.Windows.Shapes;

namespace WPF___Login_and_Registration
{
    /// <summary>
    /// Interaction logic for Regestration.xaml
    /// </summary>
    public partial class Regestration : Window
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void Registrartins(object sender, RoutedEventArgs e)
        {
            User newUser = new User(nmtxtbox.ToString(), pstxtbox.ToString());
            newUser.users.Add(newUser);
            MessageBox.Show("Kecdin Qeydiyytadan");
        }

        private void back_Login(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }
    }
}
