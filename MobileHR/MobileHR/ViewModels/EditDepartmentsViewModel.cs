using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class EditDepartmentsViewModel : ANewItemViewModel<Department>
    {
        #region Fields
        private string itemId;
        private string name;
        private string location;
        private Employee selectedEmployee;
        private string employeeValue;
        private int? idEmployee;
        #endregion
        #region Constructor
        public EditDepartmentsViewModel() : base()
        {

        }
        #endregion

        #region Properties
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(location);
        }

        public int? IdEmployee
        {
            get => IdEmployee;
            set => SetProperty(ref idEmployee, value);
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
        public string EmployeeValue
        {
            get => employeeValue;
            set => SetProperty(ref employeeValue, value);
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
        #endregion

        #region Helpers
        public override Department SetItem()
        {
            Department newItem = new Department()
            {
                ID = Convert.ToInt32(itemId),
                Name = Name,
                Location = Location,
                ManagerId = selectedEmployee.ID,

            };
            return newItem;
        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                 
                var item = await DataStore.GetItemAsync(Convert.ToInt32(itemId));
                EmployeeValue = item.ManagerName;
                Name = item.Name;
                Location = item.Location;


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        #endregion


    }
}
