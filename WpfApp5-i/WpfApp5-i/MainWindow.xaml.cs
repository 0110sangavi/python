using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp5_i
{
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



            view.Columns.Add(new GridViewColumn() { Header = "", Width = 60, DisplayMemberBinding = new Binding("squarebox") }); ;
            

            for (int i = 1; i <= columns; i++)
            {
                view.Columns.Add(new GridViewColumn() { Header = "" + i, Width = 60, CellTemplate = RadiobuttonTemplate() });
            }



            return view;
        }



        private DataTable GenerateSource(List<ItemList> dataList)
        {
            DataTable dt = new DataTable();
            DataColumn dataColumn = dt.Columns.Add("squarebox");


            foreach (var item in dataList)
            {
                DataRow row = dt.NewRow();
                row["squarebox"] = (char)item.squarebox;
                dt.Rows.Add(row);
            }



            return dt;
        }



        private DataTemplate RadiobuttonTemplate()
        {
            DataTemplate dt = new DataTemplate(typeof(RadioButton));
            FrameworkElementFactory chkElement = new FrameworkElementFactory(typeof(RadioButton));
            dt.VisualTree = chkElement;



            return dt;
        }




        public class ItemList
        {
            public int squarebox { get; set; }

        }
    }
}
