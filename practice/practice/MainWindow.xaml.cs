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

namespace practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void YesClose_Click(object sender, RoutedEventArgs e)
        {
            var closeapp = Application.Current.Windows[0];
            closeapp.Close();

            Login.LoginScreen logscreen = new Login.LoginScreen();
            logscreen.Show();
            this.Close();
        }

        private void NoClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

namespace Login
{
    class LoginScreen
    {
        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}