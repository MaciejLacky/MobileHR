using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }      
        public string Location { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }

    }
}
