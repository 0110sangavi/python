using new_wpf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_wpf
{
    
         class MainWindowViewModel : INotifyPropertyChanged
        {
            public List<Employee> empList { get; set; }

            private Employee selectedEmployee;
            public Employee SelectedEmployee
            {
                get { return selectedEmployee; }
                set
                {
                    selectedEmployee = value;
                    NotifyPropertyChanged("SelectedEmployee");
                }
            }

        public DelegateCommand<object> MyCommand { get; private set; }

            public MainWindowViewModel()
            {
                List<Employee> elist = new List<Employee>();

                elist.Add(new Employee() { EmployeeNumber = 1, FirstName = "John", LastName = "Dow", Title = "Accountant", Department = "Payroll" });
                elist.Add(new Employee() { EmployeeNumber = 2, FirstName = "Jane", LastName = "Austin", Title = "Account Executive", Department = "Employee Management" });
                elist.Add(new Employee() { EmployeeNumber = 3, FirstName = "Ralph", LastName = "Emmerson", Title = "QA Manager", Department = "Product Development" });
                elist.Add(new Employee() { EmployeeNumber = 4, FirstName = "Patrick", LastName = "Fitzgerald", Title = "QA Manager", Department = "Product Development" });
                elist.Add(new Employee() { EmployeeNumber = 5, FirstName = "Charles", LastName = "Dickens", Title = "QA Manager", Department = "Product Development" });
                empList = elist;

                MyCommand = new DelegateCommand<object>(Excute);
            }

            public void Excute(object employee)
            {
                SelectedEmployee = (Model.Employee)employee;
            }

            protected void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    System.ComponentModel.PropertyChangedEventArgs args = new System.ComponentModel.PropertyChangedEventArgs(propertyName);
                    this.PropertyChanged(this, args);
                }
            }

            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        }
    }

    internal class DelegateCommand<T>
    {
        private Action<object> excute;

        public DelegateCommand(Action<object> excute)
        {
            this.excute = excute;
        }
    }



