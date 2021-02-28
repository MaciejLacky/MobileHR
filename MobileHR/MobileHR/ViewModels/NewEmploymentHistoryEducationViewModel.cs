using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewEmploymentHistoryEducationViewModel : ANewItemViewModel<EmploymentHistEdu>
    {

        private Employee selectedEmployee;
        private string schoolName;
        private string schoolAdress;
        private string certificateName;
        private string comments;
        private DateTime? dateFrom;
        private DateTime? dateTo;
        public NewEmploymentHistoryEducationViewModel():base()
        {
            selectedEmployee = new Employee();
           
            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;
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
        public override EmploymentHistEdu SetItem()
        {
            EmploymentHistEdu newItem = new EmploymentHistEdu()
            {
                ID = 1,
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



        public override bool ValidateSave()
        {
            return true;
        }
    }
}
