using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace WpfApp6
{

    public partial class MenuUserControl : UserControl
    {
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            
        }
    }
}
