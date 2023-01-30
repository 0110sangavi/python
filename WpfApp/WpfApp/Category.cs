using System.Collections.Generic;

namespace WpfApp
{
   
    public class Category
    {
        public string CategoryName { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
