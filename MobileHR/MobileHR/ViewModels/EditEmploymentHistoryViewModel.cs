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
    public class EditEmploymentHistoryViewModel : ANewItemViewModel<EmploymentHist>
    {
        #region Fields
        private string itemId;
        private string employerName;
        private string adress;
        private string phoneNumber;
        private int? idEmployee;
        private DateTime? dateFrom;
        private DateTime? dateTo;
        private TypeContract selectedTypeContract;
        private Employee selectedEmployee;
        private TerminationWay selectedTerminationWay;
        private string comments;
        private string employeeValue;
        private string typeContractValue;
        private string terminationWayValue;

        #endregion
        #region Constructor
        public EditEmploymentHistoryViewModel() : base()
        {
            selectedEmployee = new Employee();
            selectedTypeContract = new TypeContract();
            selectedTerminationWay = new TerminationWay();
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
        public string TypeContractValue
        {
            get => typeContractValue;
            set => SetProperty(ref typeContractValue, value);
        }
        public string TerminationWayValue
        {
            get => terminationWayValue;
            set => SetProperty(ref terminationWayValue, value);
        }
        public int? IdEmployee
        {
            get => idEmployee ;
            set => SetProperty(ref idEmployee, value);
        }
        public string EmployerName
        {
            get => employerName;
            set => SetProperty(ref employerName, value);
        }

        public string Adress
        {
            get => adress;
            set => SetProperty(ref adress, value);
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetProperty(ref phoneNumber, value);
        }
        public string Comments
        {
            get => comments;
            set => SetProperty(ref comments, value);
        }

        //public List<TerminationWay> TerminationWays
        //{
        //    get
        //    {
        //        return new TerminationWaysDataStore().items;
        //    }
        //}
        public TerminationWay SelectedTerminationWay
        {
            get => selectedTerminationWay;
            set => SetProperty(ref selectedTerminationWay, value);
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

        //public List<TypeContract> TypeContracts
        //{
        //    get
        //    {
        //        return new TypeContractDataStore().items;
        //    }
        //}

        public TypeContract SelectedTypeContract
        {
            get => selectedTypeContract;
            set => SetProperty(ref selectedTypeContract, value);
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
        #endregion
        #region Helpers
        public override EmploymentHist SetItem()
        {
            EmploymentHist newItem = new EmploymentHist()
            {
                ID = Convert.ToInt32(itemId),
                EmployeeId = SelectedEmployee.ID,
                DateFrom = DateFrom,
                DateTo = DateTo,
                Comments = Comments,
                Adress = Adress,
                PhoneNumber = PhoneNumber,
                EmployerName = EmployerName,
                TypeContractId = 1,
                TerminationWayId = 1,
                //TypeContractId = SelectedTypeContract.ID,
                //TerminationWayId = selectedTerminationWay.ID,
            };
            return newItem;
        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(Convert.ToInt32(itemId));
                EmployeeValue = item.EmployeeName;
                TerminationWayValue = item.TerminationWayName;
                TypeContractValue = item.TypeContractName;
                DateFrom = item.DateFrom;
                DateTo = item.DateTo;               
                Comments = item.Comments;
                Adress = item.Adress;
                EmployerName = item.EmployerName;
                PhoneNumber = item.PhoneNumber;


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
