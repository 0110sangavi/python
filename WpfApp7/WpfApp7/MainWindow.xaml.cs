using System;
using System.Collections;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public object TextBox1 { get; private set; }
        public string TextBox { get; private set; }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = GetDataSet();
        }

        public ArrayList GetDataSet()
        {
            ArrayList items = new ArrayList();
            for (var count = 0; count < 10000; ++count)
            {
                items.Add(string.Format("Item {0}", count));
            }
            return items;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }



        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(this, "If you submit , you can't revert back.",
"Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
            else
            {
                //none
            }
        }

        private void Button2_Checked(object sender, RoutedEventArgs e)
        {
          
        }
        private void OuterButton_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "OuterButton Cliked, ";
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "InnerButton Cliked";
        }

        private void InnerButton_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
