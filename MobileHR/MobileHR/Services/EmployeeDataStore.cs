using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class EmployeeDataStore : ItemDataStore<Employee>
    {
        #region Constructor
        public EmployeeDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();           
            List<EmployeesForView> listaKFV = _MobileHRServices.GetEmployees(null).GetEmployeesResult.ToList();
            
            items = new List<Employee>();
            foreach (var k in listaKFV)
            {
                items.Add(new Employee
                {
                    ID = k.ID,
                    FirstName = k.FirstName,
                    LastName = k.LastName,
                    Code = k.Code,
                    PhoneNumber = k.PhoneNumber,
                    AdressEmail = k.AdressEmail,
                    StatusName = k.StatusName,
                    GenderName = k.GenderName,
                    DateBirth = k.DateBirth,
                    ExpirationDateIdentityCard = k.ExpirationDateIdentityCard,
                    IssueDatePassport = k.IssueDatePassport,
                    PassportNumber = k.PassportNumber,
                    Pesel = k.Pesel

                }
                    );
            }
            SortedAscItems = new List<Employee>();
            foreach (var k in items.OrderBy(x => x.LastName))
            {
                SortedAscItems.Add(
                    new Employee
                    {
                        ID = k.ID,
                        FirstName = k.FirstName,
                        LastName = k.LastName,
                        Code = k.Code,
                        PhoneNumber = k.PhoneNumber,
                        AdressEmail = k.AdressEmail,
                        StatusId = k.StatusId,
                        GenderId = k.GenderId,
                        StatusName = k.StatusName,
                        GenderName = k.GenderName,
                        DateBirth = k.DateBirth,
                        ExpirationDateIdentityCard = k.ExpirationDateIdentityCard,
                        IssueDatePassport = k.IssueDatePassport,
                        PassportNumber = k.PassportNumber,
                        Pesel = k.Pesel
                    }
                    );
            }
            SortedDescItems = new List<Employee>();
            foreach (var k in items.OrderByDescending(x => x.LastName))
            {
                SortedDescItems.Add(
                    new Employee
                    {
                        ID = k.ID,
                        FirstName = k.FirstName,
                        LastName = k.LastName,
                        Code = k.Code,
                        PhoneNumber = k.PhoneNumber,
                        AdressEmail = k.AdressEmail,
                        StatusId = k.StatusId,
                        GenderId = k.GenderId,
                        StatusName = k.StatusName,
                        GenderName = k.GenderName,
                        DateBirth = k.DateBirth,
                        ExpirationDateIdentityCard = k.ExpirationDateIdentityCard,
                        IssueDatePassport = k.IssueDatePassport,
                        PassportNumber = k.PassportNumber,
                        Pesel = k.Pesel
                    }
                    );
            }

        }
        #endregion

        #region Helpers
        public override List<Employee> SearchItems(string searchItem)
        {
            SearchList = new List<Employee>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.LastName.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Employee
                        {
                            ID = k.ID,
                            FirstName = k.FirstName,
                            LastName = k.LastName,
                            Code = k.Code,
                            PhoneNumber = k.PhoneNumber,
                            AdressEmail = k.AdressEmail,
                            StatusId = k.StatusId,
                            GenderId = k.GenderId,
                            StatusName = k.StatusName,
                            GenderName = k.GenderName,
                            DateBirth = k.DateBirth,
                            ExpirationDateIdentityCard = k.ExpirationDateIdentityCard,
                            IssueDatePassport = k.IssueDatePassport,
                            PassportNumber = k.PassportNumber,
                            Pesel = k.Pesel
                        }
                        );
                }

            }
            return SearchList;
        }
        public override void Add(Employee item)
        {

            mobileHRServices.AddEmployee(new AddEmployeeRequest(new Employees
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Code = item.Code,
                GenderId = item.GenderId,
                DateBirth = item.DateBirth,
                StatusId = item.StatusId,
                Pesel = item.Pesel,
                AdressEmail = item.AdressEmail,
            }));
        }



        public override Employee Find(Employee item)
        {
            return items.Where((Employee arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Employee Find(int id)
        {
            return items.Where((Employee arg) => arg.ID == id).FirstOrDefault();
        }

        public override void Update(Employee item)
        {
            mobileHRServices.UpdateEmployee(new UpdateEmployeeRequest(new Employees
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Code = item.Code,
                GenderId = item.GenderId,
                DateBirth = item.DateBirth,
                StatusId = item.StatusId,
                Pesel = item.Pesel,
                AdressEmail = item.AdressEmail,
                ID = item.ID,
            }));
        }
        #endregion


    }
}
