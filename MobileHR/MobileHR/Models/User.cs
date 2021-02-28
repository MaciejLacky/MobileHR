using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class User
    {
        
        public int ID { get; set; }
       
        public string LastName { get; set; }
       
        public string FirstName { get; set; }
      
        public string EmailAdress { get; set; }
       
        public string Name { get; set; }
        
        public string Password { get; set; }
       
        public bool IsAdministrator { get; set; }
       
        public int PermissionId { get; set; }
    }
}
