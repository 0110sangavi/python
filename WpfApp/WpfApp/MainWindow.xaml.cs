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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SubCategory obj = new SubCategory();
            CreateTreeView(obj);

            
        }

        public object item { get; private set; }

        private void CreateTreeView()
        {
            throw new NotImplementedException();
        }

        private void CreateTreeView(object SubCategories)
        {
            var Category = new Category() { CategoryName = "Produce", SubCategories = new List<SubCategory>() };
            var sub = new SubCategory() { SubCategoryName = "Vegetables", Items = new List<Item>() };
            var items = new Item() { ItemName = "Tomato" };
            Category.SubCategories.Add(sub);
            sub.Items.Add((Item)item);

            TreeView t = new TreeView();
            TreeViewItem tv1 = new TreeViewItem();
            tv1.Header = Category.CategoryName;
            TreeViewItem tv2 = new TreeViewItem();
            tv2.Header = sub.SubCategoryName;
            TreeViewItem tv3 = new TreeViewItem();
            tv3.Header = items.ItemName;
            tv1.Items.Add(tv2);
            tv2.Items.Add(tv3);
            t.Items.Add(tv1);
            MyDOCK.Children.Add(t);

        }
    }
    interface ICategoryName<T>
    {
        bools Equals(T obj);
    }

    public class bools
    {
    }
}

    internal class item
    {
        public item()
        {
        }

        public string ItemName { get; set; }
    }

    internal class Items 
    {
    }

    public class Category
    {
        public string CategoryName { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
    

    public class SubCategory
    {
        public string SubCategoryName { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string ItemName { get; set; }      
    }

