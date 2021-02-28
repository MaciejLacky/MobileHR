using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewContractViewModel : ANewItemViewModel<Contract>
    {
        private PickersDataStore picker = new PickersDataStore();

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
        public List<Currency> Currencies
        {
            get
            {
                return picker.itemCurrencies;
            }
        }
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set => SetProperty(ref selectedCurrency, value);
        }
        public List<Department> Departments
        {
            get
            {
                return picker.itemDepartments;
            }
        }
        public Department SelectedDepartment
        {
            get => selectedDepartment;
            set => SetProperty(ref selectedDepartment, value);
        }
        public List<Position> Positions
        {
            get
            {
                return picker.itemPosition;
            }
        }
        public Position SelectedPosition
        {
            get => selectedPosition;
            set => SetProperty(ref selectedPosition, value);
        }
        public List<TypeRate> TypeRates
        {
            get
            {
                return picker.itemTypeRate;
            }
        }
        public List<TerminationWay> TerminationWays
        {
            get
            {
                return picker.itemTerminationWays;
            }
        }
        public List<Employee> Employees
        {
            get
            {
                return new EmployeeDataStore().items;
            }
        }
        public List<TypeContract> TypeContracts
        {
            get
            {
                return picker.itemTypeContracts;
            }
        }
        public NewContractViewModel():base()
        {
            selectedEmployee = new Employee();
           
            selectedTypeContract = new TypeContract();
            
            selectedCurrency = new Currency();
           
            selectedDepartment = new Department();
           
            selectedPosition = new Position();
            
            selectedTypeRate = new TypeRate();
           
            selectedTerminationWay = new TerminationWay();
           
            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;

        }

        
        public TypeRate SelectedTypeRate
        {
            get => selectedTypeRate;
            set => SetProperty(ref selectedTypeRate, value);
        }
        
        public TerminationWay SelectedTerminationWay
        {
            get => selectedTerminationWay;
            set => SetProperty(ref selectedTerminationWay, value);
        }

       

        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set => SetProperty(ref selectedEmployee, value);
        }

       

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

        public override Contract SetItem()
        {
            Contract newItem = new Contract()
            {
                ID = 1,
                EmployeeId = SelectedEmployee.ID,              
                DateFrom = DateFrom,
                DateTo = DateTo,
                CurrencyId = 1,
                DepartmentId = 3, 
                Salary = Salary,
                PositionId = 1 ,
                TerminationWayId = 1 , 
                TypeContractsID = 1, 
                TypeRateId = 1, 
                //CurrencyId = SelectedCurrency.ID,            
                //DepartmentId = SelectedDepartment.ID,             
                //PositionId = SelectedPosition.ID,
                //TerminationWayId = SelectedTerminationWay.ID,
                //TypeContractsID = SelectedTypeContract.ID,
                //TypeRateId = SelectedTypeRate.ID

            };
            return newItem;
        }
    }
}
