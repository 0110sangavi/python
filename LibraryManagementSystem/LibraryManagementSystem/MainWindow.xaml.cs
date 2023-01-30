using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for AdminAccepted.xaml
    /// </summary>
    public partial class AdminAccepted : UserControl
    {
        //INITIALIZE THE ACCEPTED GV =>PL
        public AdminAccepted()
        {
            InitializeComponent();
            InitializeAdminAccepted();
        }
        public void InitializeAdminAccepted()
        {
            try
            {
                UserRecieveBL userRecieve = new UserRecieveBL();
                DataSet ds = userRecieve.GetAllRecieveDAL();

                ObservableCollection<AcceptedBook> lst = new ObservableCollection<AcceptedBook>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new AcceptedBook
                    {
                        BookName = Convert.ToString(dr["BookName"]),
                        BookId = Convert.ToInt32(dr["BookId"]),
                        UserId = Convert.ToInt32(dr["UserId"]),
                        UserName = Convert.ToString(dr["UserName"]),
                        DateRecieved = Convert.ToString(Convert.ToDateTime(dr["DateRecieved"]).ToShortDateString()),
                    });
                }
                dgAccepted.ItemsSource = lst;
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        
    }

    internal class AcceptedBook
    {
        public string BookName { get; internal set; }
        public int BookId { get; internal set; }
        public int UserId { get; internal set; }
        public string UserName { get; internal set; }
        public string DateRecieved { get; internal set; }
    }

    internal class UserRecieveBL
    {
        internal DataSet GetAllRecieveDAL()
        {
            throw new NotImplementedException();
        }
    }
}