using System;
using System.Collections.Generic;
using System.Data;
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

namespace dummy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
        public partial class MainWindow : Window
        {
            public int rows = 8;
            public int columns = 12;



            public MainWindow()
            {
                InitializeComponent();



                List<ItemList> listData = new List<ItemList>();



                for (int i = 0; i < rows; i++)
                {
                    listData.Add(new ItemList()
                    {
                        squarebox = i + 65
                    });



                }
                listViewData.View = GenerateGridView();
                listViewData.ItemsSource = GenerateSource(listData).DefaultView;
            }





            private GridView GenerateGridView()
            {
                GridView view = new GridView();



                view.Columns.Add(new GridViewColumn() { Header = "", Width = 60, DisplayMemberBinding = new Binding("SquareBox") }); ;
                //view.Columns.Add(new GridViewColumn() { Header = "", DisplayMemberBinding = new Binding("Name") });

                for (int i = 1; i <= columns; i++)
                {
                    view.Columns.Add(new GridViewColumn() { Header = "" + i, Width = 60, CellTemplate = CheckboxTemplate() });
                }



                return view;
            }



            private System.Data.DataTable GenerateSource(List<ItemList> dataList)
            {
            System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("SquareBox");


                foreach (var item in dataList)
                {
                    DataRow row = dt.NewRow();
                    row["SquareBox"] = (char)item.squarebox;




                    dt.Rows.Add(row);
                }



                return dt;
            }



            private DataTemplate CheckboxTemplate()
            {
                DataTemplate dt = new DataTemplate(typeof(CheckBox));
                FrameworkElementFactory chkElement = new FrameworkElementFactory(typeof(CheckBox));
                dt.VisualTree = chkElement;



                return dt;
            }




            public class ItemList
            {
                public int squarebox { get; set; }

            }
        }
}
