using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class PickersDataStore
    {
        public List<Employee> itemEmployee;
        public List<Gender> itemGender;
        public List<Status> itemStatuses;
        public List<Currency> itemCurrencies;
        public List<Department> itemDepartments;
        public List<Position> itemPosition;
        public List<TypeRate> itemTypeRate;
        public List<TerminationWay> itemTerminationWays;
        public List<TypeContract> itemTypeContracts;
        

        public PickersDataStore()
        {
            
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();
            
            List<EmployeesForView> listaEmp = _MobileHRServices.GetEmployees(null).GetEmployeesResult.ToList();
            itemEmployee = new List<Employee>();
            foreach (var k in listaEmp)
            {
                itemEmployee.Add(new Employee
                {
                    ID = k.ID,
                    FirstName = k.FirstName,
                    LastName = k.LastName,

                }
                    );
            }
            
            List<GendersForView> listaGend = _MobileHRServices.GetGenders(null).GetGendersResult.ToList();
            itemGender = new List<Gender>();
            foreach (var k in listaGend)
            {
                itemGender.Add(new Gender
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            List<StatusesForView> listaStat = _MobileHRServices.GetStatuses(null).GetStatusesResult.ToList();                      
            itemStatuses = new List<Status>();                     
            foreach (var k in listaStat)
            {
                itemStatuses.Add(new Status
                {
                    ID = k.ID,
                    Value = k.Value,
                    
                }
                    );
            }
            //List<CurrenciesForView> listaCur = _MobileHRServices.GetCurrencies(null).GetCurrenciesResult.ToList();
            //itemCurrencies = new List<Currency>();
            //foreach (var k in listaCur)
            //{
            //    itemCurrencies.Add(new Currency
            //    {
            //        ID = k.ID,
            //        Value = k.Value,

            //    }
            //        );
            //}
            //List<DepartmentsForView> listaDep = _MobileHRServices.GetDepartments(null).GetDepartmentsResult.ToList();
            //itemDepartments = new List<Department>();
            //foreach (var k in listaDep)
            //{
            //    itemDepartments.Add(new Department
            //    {
            //        ID = k.ID,
            //       Name = k.Value,

            //    }
            //        );
            //}
            //List<PositionsForView> listaPos = _MobileHRServices.GetPositions(null).GetPositionsResult.ToList();
            //itemPosition = new List<Position>();
            //foreach (var k in listaPos)
            //{
            //    itemPosition.Add(new Position
            //    {
            //        ID = k.ID,
            //        Name = k.Name,

            //    }
            //        );
            //}
            //List<TypeRatesForView> listaType = _MobileHRServices.GetTyperates(null).GetTyperatesResult.ToList();
            //itemTypeRate = new List<TypeRate>();
            //foreach (var k in listaType)
            //{
            //    itemTypeRate.Add(new TypeRate
            //    {
            //        ID = k.ID,
            //       Value = k.Value,

            //    }
            //        );
            //}
            //List<TerminationWaysForView> listaTer = _MobileHRServices.GetTerminationWays(null).GetTerminationWaysResult.ToList();
            //itemTerminationWays = new List<TerminationWay>();
            //foreach (var k in listaTer)
            //{
            //    itemTerminationWays.Add(new TerminationWay
            //    {
            //        ID = k.ID,
            //        Value = k.Value,

            //    }
            //        );
            //}
            //List<TypeContractsForView> listaTypeC = _MobileHRServices.GetTypeContracts(null).GetTypeContractsResult.ToList();
            //itemTypeContracts = new List<TypeContract>();
            //foreach (var k in listaTypeC)
            //{
            //    itemTypeContracts.Add(new TypeContract
            //    {
            //        ID = k.ID,
            //        Value = k.Value,

            //    }
            //        );
            //}



        }

    }
}
