using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewEmploymentHistoryViewModel : ANewItemViewModel<EmploymentHist>
    {

        private string employerName;
        private string adress;
        private string phoneNumber;       
        private DateTime? dateFrom;
        private DateTime? dateTo;
        private TypeContract selectedTypeContract;
        private Employee selectedEmployee;
        private TerminationWay selectedTerminationWay;
        private string comments;
        public NewEmploymentHistoryViewModel():base()
        {
            selectedEmployee = new Employee();          
            selectedTypeContract = new TypeContract();
            selectedTerminationWay = new TerminationWay();
            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;
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
        public override EmploymentHist SetItem()
        {
            EmploymentHist newItem = new EmploymentHist()
            {
                ID = 1,
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

        public override bool ValidateSave()
        {
            return true;
        }
    }
}
