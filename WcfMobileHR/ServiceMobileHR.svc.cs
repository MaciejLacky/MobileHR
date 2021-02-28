using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfMobileHR.Model.Entities;

namespace WcfMobileHR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceMobileHR : IServiceMobileHR
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<ContractsForView> GetContracts()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from contract in db.Contracts
                select new ContractsForView
                {
                    ID = contract.ID,
                    CurrencyId = contract.CurrencyId,
                    CurrencyName = contract.Currencies.Value,
                    DateFrom = contract.DateFrom,
                    DateTo = contract.DateTo,
                    DepartmentId = contract.DepartmentId,
                    EmployeDepartmentName = contract.Departments.Name,
                    TypeContractsID = contract.TypeContractsID,
                    TypeContractName = contract.TypeContracts.Value,
                    TerminationWayId = contract.TerminationWayId,
                    TerminationWayName = contract.TerminationWays.Value,
                    Salary = contract.Salary,
                    EmployeeName = contract.Employees.FirstName + " " + contract.Employees.LastName,
                    EmployeeId = contract.EmployeeId,
                    PositionId = contract.PositionId,
                    PositionName = contract.Positions.Name,
                    TypeRateId = contract.TypeRateId,
                    TypeRateName = contract.TypeRates.Value
                }
                ).ToList();
        }
        public void UpdateContract(Contracts contract)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).CurrencyId = contract.CurrencyId;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).DateFrom = contract.DateTo;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).DateTo = contract.DateTo;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).DepartmentId = contract.DepartmentId;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).TypeContractsID = contract.TypeContractsID;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).TerminationWayId = contract.TerminationWayId;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).Salary = contract.Salary;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).EmployeeId = contract.EmployeeId;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).PositionId = contract.PositionId;
            db.Contracts.FirstOrDefault(x => x.ID == contract.ID).TypeRateId = contract.TypeRateId;
            db.SaveChanges();
        }
        public void AddContract(Contracts contract)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Contracts.Add(contract);
            db.SaveChanges();
        }

        public List<CurrenciesForView> GetCurrencies()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from currency in db.Currencies
                select new CurrenciesForView
                {
                    ID = currency.ID,
                    Value = currency.Value
                }
                ).ToList();
        }
        public void AddCurrency(Currencies currency)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Currencies.Add(currency);
            db.SaveChanges();
        }

        public List<DepartmentsForView> GetDepartments()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from department in db.Departments
                select new DepartmentsForView
                {
                    ID = department.ID,
                    Value = department.Name,
                    Location = department.Location,
                    ManagerId = department.ManagerId,
                    ManagerName = department.Employees.FirstName + department.Employees.LastName,
                    ParentDepartmentId = department.ParentDepartmentId,

                    
                }
                ).ToList();
        }
        public void UpdateDepartment(Departments departent)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Departments.FirstOrDefault(x => x.ID == departent.ID).Name = departent.Name;
            db.Departments.FirstOrDefault(x => x.ID == departent.ID).Location = departent.Location;
            db.Departments.FirstOrDefault(x => x.ID == departent.ID).ManagerId = departent.ManagerId;
            db.SaveChanges();
        }

        public void AddDepartment(Departments department)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Departments.Add(department);
            db.SaveChanges();
        }

        public List<EmployeesForView> GetEmployees()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from employee in db.Employees
                select new EmployeesForView
                {
                    LastName = employee.LastName,
                    FirstName = employee.FirstName,
                    Code = employee.Code,
                    DateBirth = employee.DateBirth,
                    Pesel = employee.Pesel,
                    PhoneNumber = employee.PhoneNumber,
                    AdressEmail = employee.AdressEmail,
                    ExpirationDateIdentityCard = employee.ExpirationDateIdentityCard,
                    ExpirationDatePassport = employee.ExpirationDatePassport,
                    GenderName = employee.Genders.Value,
                    StatusName = employee.Statuses.Value,
                    GenderId = employee.GenderId,
                    ID = employee.ID,
                    IsseuDateIdentityCard = employee.IsseuDateIdentityCard,
                    IssueDatePassport = employee.IssueDatePassport,
                    PassportNumber = employee.PassportNumber,
                    StatusId = employee.StatusId
                }

                ).ToList();


        }
        public void UpdateEmployee(Employees employee)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).LastName = employee.LastName;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).FirstName = employee.FirstName;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).Code = employee.Code;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).DateBirth = employee.DateBirth;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).Pesel = employee.Pesel;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).PhoneNumber = employee.PhoneNumber;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).AdressEmail = employee.AdressEmail;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).GenderId = employee.GenderId;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).StatusId = employee.StatusId;
            db.Employees.FirstOrDefault(x => x.ID == employee.ID).PassportNumber = employee.PassportNumber;
            db.SaveChanges();
        }

        public void AddEmployee(Employees employee)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public List<GendersForView> GetGenders()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from gender in db.Genders
                select new GendersForView 
                { 
                    ID = gender.ID,
                    Value = gender.Value
                }
                ).ToList();
        }
        public void AddGender(Genders gender)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Genders.Add(gender);
            db.SaveChanges();
        }

        public List<PermissionsForView> GetPermissions()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from permission in db.Permissions
                select new PermissionsForView
                {
                    ID = permission.ID,
                    EditEmployees = permission.EditEmployees,
                    ShowEmployees = permission.ShowEmployees,
                    UserId = permission.UserId
                }
                ).ToList();
        }

        public List<PositionsForView> GetPositions()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from position in db.Positions
                select new PositionsForView
                {
                    ID = position.ID,
                    MaxSalary = position.MaxSalary,
                    MinSalary = position.MinSalary,
                    Name = position.Name

                }
                ).ToList();
        }
        public void AddPosition(Positions position)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Positions.Add(position);
            db.SaveChanges();
        }

        public List<StatusesForView> GetStatuses()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from status in db.Statuses
                select new StatusesForView
                {
                    ID = status.ID,
                    Value = status.Value
                }
                ).ToList();
        }
        public void AddStatus(Statuses status)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Statuses.Add(status);
            db.SaveChanges();
        }

        public List<TerminationWaysForView> GetTerminationWays()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from terminationWay in db.TerminationWays
                select new TerminationWaysForView
                {
                    ID = terminationWay.ID,
                    Value = terminationWay.Value
                }
                ).ToList();
        }
        public void AddTerminationWay(TerminationWays terminationWay)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.TerminationWays.Add(terminationWay);
            db.SaveChanges();
        }
        public List<TypeContractsForView> GetTypeContracts()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from typeContract in db.TypeContracts
                select new TypeContractsForView
                {
                    ID = typeContract.ID,
                    Value = typeContract.Value
                }
                ).ToList();
        }
        public void AddTypeContract(TypeContracts typeContract)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.TypeContracts.Add(typeContract);
            db.SaveChanges();
        }

        public List<TypeRatesForView> GetTyperates()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from typeRate in db.TypeRates
                select new TypeRatesForView
                {
                    ID = typeRate.ID,
                    Value = typeRate.Value
                }
                ).ToList();
        }
        public void AddTypeRate(TypeRates typeRate)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.TypeRates.Add(typeRate);
            db.SaveChanges();
        }

        public List<UsersForView> GetUsers()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (
                from user in db.Users
                select new UsersForView
                {
                    ID = user.ID,
                    EmailAdress = user.EmailAdress,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Name = user.Name,
                    Password = user.Password,
                    PermissionId = user.PermissionId,
                    IsAdministrator = user.IsAdministrator

                }
                ).ToList();

        }

        public List<EmploymentHistoryForView> GetEmploymentHistories()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return 
                (
                    from employee in db.EmploymentHistory
                    select new EmploymentHistoryForView
                    {
                        ID = employee.ID,
                        EmployerName = employee.EmployerName,
                        Adress = employee.Adress,
                        EmployeeName = employee.Employees.FirstName + " " + employee.Employees.LastName,
                        Comments = employee.Comments,
                        DateFrom = employee.DateFrom,
                        DateTo = employee.DateTo,
                        PhoneNumber = employee.PhoneNumber,
                        TerminationWayName = employee.TerminationWays.Value,
                        TypeContractName = employee.TypeContracts.Value,
                        
                    }

                ).ToList();
        }
        public void UpdateEmpHist(EmploymentHistory employmentHistory)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).EmployerName = employmentHistory.EmployerName;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).Adress = employmentHistory.Adress;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).Comments = employmentHistory.Comments;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).DateFrom = employmentHistory.DateFrom;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).DateTo = employmentHistory.DateTo;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).PhoneNumber = employmentHistory.PhoneNumber;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).TerminationWayId = employmentHistory.TerminationWayId;
            db.EmploymentHistory.FirstOrDefault(x => x.ID == employmentHistory.ID).TypeContractId = employmentHistory.TypeContractId;
            db.SaveChanges();
        }
        public void AddEmploymentHistory(EmploymentHistory employmentHistory)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.EmploymentHistory.Add(employmentHistory);
            db.SaveChanges();
        }


        public List<EmploymentHistoryEducationForView> GetEmploymentHistoryEducations()
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return
                (
                    from employee in db.EmploymentHistoryEducation
                    select new EmploymentHistoryEducationForView
                    {
                        ID = employee.ID,
                        EmployeeName = employee.Employees.FirstName + " " + employee.Employees.LastName,
                        CertificateName = employee.CertificateName,
                        Comments = employee.Comments,
                        SchoolAdress = employee.SchoolAdress,
                        SchoolName = employee.SchoolName,
                        DateFrom = employee.DateFrom,
                        DateTo = employee.DateTo,

                    }

                ).ToList();
        }

       
        public void AddEmploymentHistoryEdu(EmploymentHistoryEducation employmentHistoryEdu)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.EmploymentHistoryEducation.Add(employmentHistoryEdu);
            db.SaveChanges();
        }

 
        public void UpdateEmpHistEdu(EmploymentHistoryEducation employmentHistoryEdu)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).EmployeeId = employmentHistoryEdu.EmployeeId;
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).SchoolAdress = employmentHistoryEdu.SchoolAdress;
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).Comments = employmentHistoryEdu.Comments;
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).DateFrom = employmentHistoryEdu.DateFrom;
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).DateTo = employmentHistoryEdu.DateTo;          
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).SchoolName = employmentHistoryEdu.SchoolName;
            db.EmploymentHistoryEducation.FirstOrDefault(x => x.ID == employmentHistoryEdu.ID).CertificateName = employmentHistoryEdu.CertificateName;
            db.SaveChanges();
        }

        public IQueryable<Employees> EmployeeEndContract(int idStatus, DateTime? dateFrom, DateTime? dateTo)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.DateFrom >= dateFrom
                    && emp.DateTo <= dateTo
                    && emp.Employees.StatusId == idStatus
                    select emp.Employees
                   );
        }

        public IQueryable<Employees> EmployeeSalaries(int idEmployee, decimal salaryFrom, decimal salaryTo)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.EmployeeId == idEmployee
                    && emp.Positions.MinSalary >= salaryFrom
                    && emp.Positions.MaxSalary <= salaryTo
                    select emp.Employees

                   );
        }

        public IQueryable<Employees> EmployeeDepartment(int idDepartment)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.DepartmentId == idDepartment                   
                    select emp.Employees
                   );
        }

        public int? EmployeeCount(int idDepartment)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.DepartmentId == idDepartment
                    select emp
                   ).Count();
        }

        public int? EmployeeIsActive(DateTime dateFrom, DateTime dateTo)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.DateFrom >= dateFrom && emp.DateTo <= dateTo
                   && emp.Employees.StatusId == 2
                    select emp
                   ).Count();
        }

        public int? EmployeeSalariesRaport(decimal? salaryFrom, decimal? salaryTo)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            return (from emp in db.Contracts
                    where emp.Salary >= salaryFrom && emp.Salary <= salaryTo
                    select emp
                   ).Count();
        }

        public void UpdateTypeContract(TypeContracts typeContract)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.TypeContracts.FirstOrDefault(x => x.ID == typeContract.ID).Value = typeContract.Value;
            db.SaveChanges();
        }

        public void UpdateStatus(Statuses status)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Statuses.FirstOrDefault(x => x.ID == status.ID).Value = status.Value;
            db.SaveChanges();
        }

        public void UpdateGender(Genders gender)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Genders.FirstOrDefault(x => x.ID == gender.ID).Value = gender.Value;
            db.SaveChanges();
        }

        public void UpdatePosition(Positions position)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Positions.FirstOrDefault(x => x.ID == position.ID).Name = position.Name;
            db.Positions.FirstOrDefault(x => x.ID == position.ID).MinSalary = position.MinSalary;
            db.Positions.FirstOrDefault(x => x.ID == position.ID).MaxSalary = position.MaxSalary;
            db.SaveChanges();
        }

        public void UpdateCurrency(Currencies currency)
        {
            HumanResourcesDBEntities db = new HumanResourcesDBEntities();
            db.Currencies.FirstOrDefault(x => x.ID == currency.ID).Value = currency.Value;
            db.SaveChanges();
        }
    }
}
