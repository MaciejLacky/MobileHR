using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class EmploymentHist
    {
        public int ID { get; set; }
        public string EmployerName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> TypeContractId { get; set; }
        public string TypeContractName { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<int> TerminationWayId { get; set; }
        public string TerminationWayName { get; set; }
        public string Comments { get; set; }
    }
}
