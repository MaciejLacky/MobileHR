using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class Contract

    {
       
        public int ID { get; set; }
       
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        
        public int? TypeContractsID { get; set; }
        public string TypeContractName { get; set; }

        public DateTime? DateFrom { get; set; }
        
        public DateTime? DateTo { get; set; }
       
        public int PositionId { get; set; }

        public string PositionName { get; set; }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public decimal? Salary { get; set; }
        
        public int CurrencyId { get; set; }

        public string CurrencyName { get; set; }

        public int TypeRateId { get; set; }

        public string TypeRateName { get; set; }

        public int? TerminationWayId { get; set; }

        public string TerminationWayName { get; set; }
    }
}
