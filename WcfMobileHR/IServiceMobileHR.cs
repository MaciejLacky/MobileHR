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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceMobileHR
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<EmployeesForView> GetEmployees();
        [OperationContract]
        List<GendersForView> GetGenders();
        [OperationContract]
        List<CurrenciesForView> GetCurrencies();
        [OperationContract]
        List<DepartmentsForView> GetDepartments();
        [OperationContract]
        List<ContractsForView> GetContracts();
        [OperationContract]
        List<PositionsForView> GetPositions();
        [OperationContract]
        List<StatusesForView> GetStatuses();
        [OperationContract]
        List<TerminationWaysForView> GetTerminationWays();
        [OperationContract]
        List<TypeContractsForView> GetTypeContracts();
        [OperationContract]
        List<TypeRatesForView> GetTyperates();
        [OperationContract]
        List<UsersForView> GetUsers();
        [OperationContract]
        List<PermissionsForView> GetPermissions();
        [OperationContract]
        List<EmploymentHistoryForView> GetEmploymentHistories();
        [OperationContract]
        List<EmploymentHistoryEducationForView> GetEmploymentHistoryEducations();
        [OperationContract]
        void AddEmployee(Employees employee);
        [OperationContract]
        void AddContract(Contracts contract);
        [OperationContract]
        void AddDepartment(Departments department);
        [OperationContract]
        void AddCurrency(Currencies currency);
        [OperationContract]
        void AddGender(Genders gender);
        [OperationContract]
        void AddPosition(Positions position);
        [OperationContract]
        void AddStatus(Statuses status);
        [OperationContract]
        void AddTerminationWay(TerminationWays terminationWay);
        [OperationContract]
        void AddTypeContract(TypeContracts typeContract);
        [OperationContract]
        void AddTypeRate(TypeRates typeRate);
        [OperationContract]
        void AddEmploymentHistory(EmploymentHistory employmentHistory);
        [OperationContract]
        void AddEmploymentHistoryEdu(EmploymentHistoryEducation employmentHistoryEdu);
        [OperationContract]
        void UpdateTypeContract(TypeContracts typeContract);
        [OperationContract]
        void UpdateStatus(Statuses status);
        [OperationContract]
        void UpdateGender(Genders gender);
        [OperationContract]
        void UpdatePosition(Positions position);
        [OperationContract]
        void UpdateCurrency(Currencies currency);
        [OperationContract]
        void UpdateEmployee(Employees employee);
        [OperationContract]
        void UpdateContract(Contracts contract);
        [OperationContract]
        void UpdateDepartment(Departments departent);
        [OperationContract]
        void UpdateEmpHist(EmploymentHistory employmentHistory);
        [OperationContract]
        void UpdateEmpHistEdu(EmploymentHistoryEducation employmentHistoryEdu);
        [OperationContract]
        IQueryable<Employees> EmployeeEndContract(int idStatus , DateTime? dateFrom, DateTime? dateTo);
        [OperationContract]
        IQueryable<Employees> EmployeeSalaries(int idEmployee, decimal salaryFrom, decimal salaryTo);
        [OperationContract]
        IQueryable<Employees> EmployeeDepartment(int idDepartment);
        [OperationContract]
        int? EmployeeCount(int idDepartment);
        [OperationContract]
        int? EmployeeIsActive(DateTime dateFrom, DateTime dateTo);
        [OperationContract]
        int? EmployeeSalariesRaport(decimal? salaryFrom, decimal? salaryTo);
    }

    [DataContract]
    public class EmploymentHistoryForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string EmployerName { get; set; }
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public Nullable<int> TypeContractId { get; set; }
        [DataMember]
        public string TypeContractName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateFrom { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateTo { get; set; }
        [DataMember]
        public Nullable<int> EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public Nullable<int> TerminationWayId { get; set; }
        [DataMember]
        public string TerminationWayName { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }
    [DataContract]
    public class EmploymentHistoryEducationForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public Nullable<int> EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string SchoolName { get; set; }
        [DataMember]
        public string SchoolAdress { get; set; }
        [DataMember]
        public string CertificateName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateFrom { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateTo { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }
    [DataContract]
    public class PermissionsForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public bool? ShowEmployees { get; set; }
        [DataMember]
        public bool? EditEmployees { get; set; }
    }
    [DataContract]
    public class UsersForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string EmailAdress { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool IsAdministrator { get; set; }
        [DataMember]
        public int PermissionId { get; set; }

    }
    [DataContract]
    public class TypeRatesForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
    [DataContract]
    public class TypeContractsForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
    [DataContract]
    public class TerminationWaysForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
    [DataContract]
    public class StatusesForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
    [DataContract]
    public class PositionsForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal? MaxSalary { get; set; }
        [DataMember]
        public decimal? MinSalary { get; set; }
    }
    [DataContract]
    public class ContractsForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int? EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public int? TypeContractsID { get; set; }
        [DataMember]
        public string TypeContractName { get; set; }
        [DataMember]
        public DateTime? DateFrom { get; set; }
        [DataMember]
        public DateTime? DateTo { get; set; }
        [DataMember]
        public int? PositionId { get; set; }
        [DataMember]
        public string PositionName { get; set; }
        [DataMember]
        public int? DepartmentId { get; set; }
        [DataMember]
        public string EmployeDepartmentName { get; set; }
        [DataMember]
        public decimal? Salary { get; set; }
        [DataMember]
        public int? CurrencyId { get; set; }
        [DataMember]
        public string CurrencyName { get; set; }
        [DataMember]
        public int? TypeRateId { get; set; }
        [DataMember]
        public string TypeRateName { get; set; }
        [DataMember]
        public int? TerminationWayId { get; set; }
        [DataMember]
        public string TerminationWayName { get; set; }

    }
    [DataContract]
    public class DepartmentsForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public int? ManagerId { get; set; }
        [DataMember]
        public string ManagerName { get; set; }
        [DataMember]
        public int? ParentDepartmentId { get; set; }
    }
    [DataContract]
    public class CurrenciesForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }

    [DataContract]
    public class GendersForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Value { get; set; }
    }

    [DataContract]
    public class EmployeesForView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public int? GenderId { get; set; }
        [DataMember]
        public string GenderName { get; set; }
        [DataMember]
        public DateTime? DateBirth { get; set; }
        [DataMember]
        public string Pesel { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string AdressEmail { get; set; }
        [DataMember]
        public DateTime? IsseuDateIdentityCard { get; set; }
        [DataMember]
        public DateTime? ExpirationDateIdentityCard { get; set; }
        [DataMember]
        public string PassportNumber { get; set; }
        [DataMember]
        public DateTime? IssueDatePassport { get; set; }
        [DataMember]
        public DateTime? ExpirationDatePassport { get; set; }
        [DataMember]
        public int StatusId { get; set; }
        [DataMember]
        public string StatusName { get; set; }
    }




    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
