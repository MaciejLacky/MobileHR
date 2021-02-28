using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class RaportsDataStore
    {
        public IServiceMobileHR serviceMobileHR { get; set; }
        public RaportsDataStore()
        {
            serviceMobileHR = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();
        }

        public List<Employees> EmployeeEndContract(int idStatus, DateTime? dateFrom, DateTime? dateTo)
        {
            return serviceMobileHR.EmployeeEndContract(new EmployeeEndContractRequest(idStatus, dateFrom, dateTo)).EmployeeEndContractResult;
            

        }

        public List<Employees> EmployeeSalaries(int idEmployee, decimal salaryFrom, decimal salaryTo)
        {
            return serviceMobileHR.EmployeeSalaries(new EmployeeSalariesRequest(idEmployee, salaryFrom, salaryTo)).EmployeeSalariesResult;
        }

        public List<Employees> EmployeeDepartment(int idDepartment)
        {
            return serviceMobileHR.EmployeeDepartment(new EmployeeDepartmentRequest(idDepartment)).EmployeeDepartmentResult;
        }
        public int? EmployeeCount(int idDepartment)
        {
            return serviceMobileHR.EmployeeCount(new EmployeeCountRequest(idDepartment)).EmployeeCountResult;
        }

        public int? EmployeeIsActive(DateTime dateFrom, DateTime dateTo)
        {
            return serviceMobileHR.EmployeeIsActive(new EmployeeIsActiveRequest(dateFrom, dateTo)).EmployeeIsActiveResult;
        }
        public int? EmployeeSalariesRaport(decimal? salaryFrom, decimal? salaryTo)
        {
            return serviceMobileHR.EmployeeSalariesRaport(new EmployeeSalariesRaportRequest(salaryFrom, salaryTo)).EmployeeSalariesRaportResult;
        }
    }
}
