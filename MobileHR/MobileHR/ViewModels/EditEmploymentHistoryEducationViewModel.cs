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
    public class EditEmploymentHistoryEducationViewModel : ANewItemViewModel<EmploymentHistEdu>
    {
        #region Fields
        private string itemId;
        private Employee selectedEmployee;
        private string schoolName;
        private string schoolAdress;
        private string certificateName;
        private string comments;
        private DateTime? dateFrom;
        private DateTime? dateTo;
        private string employeeValue;
        #endregion
        #region Constructor
        public EditEmploymentHistoryEducationViewModel() : base()
        {
            selectedEmployee = new Employee();

            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;
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
        public string EmployeeValue
        {
            get => employeeValue;
            set => SetProperty(ref employeeValue, value);
        }
        public string SchoolName
        {
            get => schoolName;
            set => SetProperty(ref schoolName, value);
        }

        public string SchoolAdress
        {
            get => schoolAdress;
            set => SetProperty(ref schoolAdress, value);
        }
        public string CertificateName
        {
            get => certificateName;
            set => SetProperty(ref certificateName, value);
        }
        public string Comments
        {
            get => comments;
            set => SetProperty(ref comments, value);
        }
        public DateTime? DateFrom
        {
            get => dateFrom;
            set => SetProperty(ref dateFrom, value);
        }
        public DateTime? DateTo
        {
            get => dateTo;
            set => SetProperty(ref dateTo, value);
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
        #endregion
        #region Helpers
        public override EmploymentHistEdu SetItem()
        {
            EmploymentHistEdu newItem = new EmploymentHistEdu()
            {
                ID = Convert.ToInt32(itemId),
                EmployeeId = SelectedEmployee.ID,
                DateFrom = DateFrom,
                DateTo = DateTo,
                CertificateName = CertificateName,
                Comments = Comments,
                SchoolAdress = SchoolAdress,
                SchoolName = SchoolName,


            };
            return newItem;
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(Convert.ToInt32(itemId));
                EmployeeValue = item.EmployeeName;
                DateFrom = item.DateFrom;
                DateTo = item.DateTo;
                CertificateName = item.CertificateName;
                Comments = item.Comments;
                SchoolAdress = item.SchoolAdress;
                SchoolName = item.SchoolName;


            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public override bool ValidateSave()
        {
            return true;
        }
        #endregion


    }
}
