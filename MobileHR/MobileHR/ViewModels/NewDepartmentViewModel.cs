using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewDepartmentViewModel : ANewItemViewModel<Department>
    {       
        private string name;
        private string location;
        private Employee selectedEmployee;

        public NewDepartmentViewModel():base()
        {
            
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(location);
        }

        public List<Employee> Employees
        {
            get
            {
                return new EmployeeDataStore().items;
            }
        }

        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set => SetProperty(ref selectedEmployee, value);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Location
        {
            get => location;
            set => SetProperty(ref location, value);
        }

        public override Department SetItem()
        {
            Department newItem = new Department()
            {
                ID = 1,
                Name = Name,
                Location = Location,
                ManagerId = selectedEmployee.ID,

            };
            return newItem;
        }
    }
}
