using MobileHR.Models;
using MobileHR.Services;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class EmployeeRaportEndViewModel : BaseViewModel
    {
        #region Fields
        private int idStatus;
        private int idDepartment;
        private decimal? salaryFrom;
        private decimal? salaryTo;
        private DateTime dateFrom;
        private DateTime dateTo;
        private Status selectedStatuses;
        //private List<Employees> employees;
        private int? numberEmployee;
        private Department selectedDepartment;
        #endregion
        #region Constructor
        public EmployeeRaportEndViewModel()
        {
            selectedStatuses = new Status();
            selectedDepartment = new Department();
            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;
            EmployeeEndContract = new Command(employeeEndContract);
            EmployeeIsActive = new Command(employeeIsActive);
            EmployeeSalary = new Command(employeeSalary);
            //employees = new List<Employees>();
            numberEmployee = 0;
        }

       
        #endregion
        #region Properties
        //public List<Employees> Employees
        //{
        //    get
        //    {
        //        return employees;
        //    }
        //    set
        //    {
        //        employees = value;
        //    }

        //}
        public List<Department> Departments
        {
            get
            {
                return new DepartmentsDataStore().items;
            }
        }
        public Department SelectedDepartment
        {
            get => selectedDepartment;
            set => SetProperty(ref selectedDepartment, value);
        }
        public List<Status> Statuses
        {
            get
            {
                return new StatusesDataStore().items;
            }
        }
        public Status SelectedStatus
        {
            get => selectedStatuses;
            set => SetProperty(ref selectedStatuses, value);
        }
        public int? NumberEmployee
        {
            get => numberEmployee;
            set => SetProperty(ref numberEmployee, value);
        }
        public int IdStatus
        {
            get => idStatus = selectedStatuses.ID;
            set => SetProperty(ref idStatus, value);
        }
        public decimal? SalaryFrom
        {
            get => salaryFrom;
            set => SetProperty(ref salaryFrom, value);
        }
        public decimal? SalaryTo
        {
            get => salaryTo;
            set => SetProperty(ref salaryTo, value);
        }
        public int IdDepartment
        {
            get => idDepartment = selectedDepartment.ID;
            set => SetProperty(ref idDepartment, value);
        }
        public DateTime DateFrom
        {
            get => dateFrom;
            set => SetProperty(ref dateFrom, value);
        }
        public DateTime DateTo
        {
            get => dateTo;
            set => SetProperty(ref dateTo, value);
        }
        #endregion
        #region Commands
        public Command EmployeeEndContract { get; }
        public Command EmployeeIsActive { get; }
        public Command EmployeeSalary { get; }
        #endregion
        #region Helpers
        private void employeeEndContract()
        {
            //var list = new RaportsDataStore().EmployeeEndContract(IdStatus, DateFrom, DateTo);
            //NumberEmployee = list.Count;
            NumberEmployee = new RaportsDataStore().EmployeeCount(IdDepartment);
            
        }
        private void employeeIsActive()
        {
            NumberEmployee = new RaportsDataStore().EmployeeIsActive(DateFrom, DateTo);
        }
        private void employeeSalary()
        {
            NumberEmployee = new RaportsDataStore().EmployeeSalariesRaport(SalaryFrom, SalaryTo);
        }
        #endregion


    }
}
