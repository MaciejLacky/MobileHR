using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class EmploymentHistEdu
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAdress { get; set; }
        public string CertificateName { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string Comments { get; set; }
    }
}
