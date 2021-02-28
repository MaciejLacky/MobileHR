using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class Permission
    {
        
        public int ID { get; set; }
      
        public int UserId { get; set; }
        
        public bool ShowEmployees { get; set; }
       
        public bool EditEmployees { get; set; }
    }
}
