using System;

namespace MobileHR.Models
{
    public class Employee
    {
        public int ID { get; set; }
       
        public string LastName { get; set; }
       
        public string FirstName { get; set; }
        
        public int Code { get; set; }
        
        public int GenderId { get; set; }
       
        public DateTime? DateBirth { get; set; }
        
        public string Pesel { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string AdressEmail { get; set; }
        
        public DateTime? IsseuDateIdentityCard { get; set; }
        
        public DateTime? ExpirationDateIdentityCard { get; set; }
        
        public string PassportNumber { get; set; }
        public string StatusName { get; set; }
        public string GenderName { get; set; }

        public DateTime? IssueDatePassport { get; set; }
       
        public DateTime? ExpirationDatePassport { get; set; }
        
        public int StatusId { get; set; }
    }
}
