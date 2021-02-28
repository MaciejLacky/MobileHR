using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text;
using Xamarin.Forms;
using Contract = MobileHR.Models.Contract;

namespace MobileHR.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class EditContractsViewModel : ANewItemViewModel<Contract>
    {
        #region Fields
        private string itemId;
        private DateTime? dateFrom;
        private DateTime? dateTo;
        private Employee selectedEmployee;
        private TypeContract selectedTypeContract;
        private Position selectedPosition;
        private Department selectedDepartment;
        private decimal? salary;
        private Currency selectedCurrency;
        private TypeRate selectedTypeRate;
        private TerminationWay selectedTerminationWay;
        private string employeeValue;
        private string typeContractValue;
        private string positionValue;
        private string departmentValue;
        private string currencyValue;
        private string typeRateValue;
        private string terminationWayValue;
        #endregion

        #region Constructor
        public EditContractsViewModel() : base()
        {
            selectedEmployee = new Employee();
            selectedTypeContract = new TypeContract();
            selectedCurrency = new Currency();
            selectedDepartment = new Department();
            selectedPosition = new Position();
            selectedTypeRate = new TypeRate();
            selectedTerminationWay = new TerminationWay();
        }
        #endregion
        #region Properties
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
        public string PositionValue
        {
            get => positionValue;
            set => SetProperty(ref positionValue, value);
        }
        public string DepartmentValue
        {
            get => departmentValue;
            set => SetProperty(ref departmentValue, value);
        }
        public string CurrencyValue
        {
            get => currencyValue;
            set => SetProperty(ref currencyValue, value);
        }
        public string TypeRateValue
        {
            get => typeRateValue;
            set => SetProperty(ref typeRateValue, value);
        }
        public string TerminationWayValue
        {
            get => terminationWayValue;
            set => SetProperty(ref terminationWayValue, value);
        }
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
        //public List<Currency> Currencies
        //{
        //    get
        //    {
        //        return new CurrenciesDataStore().items;
        //    }
        //}
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set => SetProperty(ref selectedCurrency, value);
        }
        //public List<Department> Departments
        //{
        //    get
        //    {
        //        return new DepartmentsDataStore().items;
        //    }
        //}
        public Department SelectedDepartment
        {
            get => selectedDepartment;
            set => SetProperty(ref selectedDepartment, value);
        }
        //public List<Position> Positions
        //{
        //    get
        //    {
        //        return new PositionDataStore().items;
        //    }
        //}
        public Position SelectedPosition
        {
            get => selectedPosition;
            set => SetProperty(ref selectedPosition, value);
        }
        //public List<TypeRate> TypeRates
        //{
        //    get
        //    {
        //        return new TypeRatesDataStore().items;
        //    }
        //}
        public TypeRate SelectedTypeRate
        {
            get => selectedTypeRate;
            set => SetProperty(ref selectedTypeRate, value);
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
        public override bool ValidateSave()
        {
            //if (employeeId != 0 && typeContractId != 0)
            //{
            //    return true;
            //}
            //else
            //    return false;
            return true;
        }


        public decimal? Salary
        {
            get => salary;
            set => SetProperty(ref salary, value);
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
        public override Contract SetItem()
        {
            Contract newItem = new Contract()
            {
                ID = Convert.ToInt32(itemId),
                EmployeeId = SelectedEmployee.ID,
                Salary = Salary,
                DateFrom = DateFrom,
                DateTo = DateTo,
                DepartmentId = 3,
                PositionId = 1,
                TerminationWayId = 1,
                TypeContractsID = 1,
                TypeRateId = 1,
                CurrencyId = 1,
                //DepartmentId = SelectedDepartment.ID,              
                //PositionId = SelectedPosition.ID,
                //TerminationWayId = SelectedTerminationWay.ID,
                //TypeContractsID = SelectedTypeContract.ID,
                //TypeRateId = SelectedTypeRate.ID,
                //CurrencyId = SelectedCurrency.ID,

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
                CurrencyValue = item.CurrencyName;
                DepartmentValue = item.DepartmentName;
                Salary = item.Salary;
                PositionValue = item.PositionName;
                TerminationWayValue = item.TerminationWayName;
                TypeContractValue = item.TypeContractName;
                TypeRateValue = item.TypeRateName;
                DepartmentValue = item.DepartmentName;
                CurrencyValue = item.CurrencyName;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        #endregion


    }
}
