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
    public class ContractDataStore : ItemDataStore<Contract>
    {
        

        public ContractDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<ContractsForView> listaKFV = _MobileHRServices.GetContracts(null).GetContractsResult.ToList();          
            items = new List<Contract>();

            foreach (var k in listaKFV)
            {
                items.Add(new Contract
                {
                    ID = k.ID,
                    Salary = k.Salary,
                    DateFrom = k.DateFrom,
                    DateTo = k.DateTo,
                    EmployeeName = k.EmployeeName,
                    TypeContractName = k.TypeContractName,
                    TypeRateName = k.TypeRateName,
                    PositionName = k.PositionName,
                    DepartmentName = k.EmployeDepartmentName,
                    CurrencyName = k.CurrencyName
                }
                    ) ;
            }
            SortedAscItems = new List<Contract>();
            foreach (var k in items.OrderBy(x => x.EmployeeName))
            {
                SortedAscItems.Add(
                    new Contract
                    {
                        ID = k.ID,
                        Salary = k.Salary,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        EmployeeName = k.EmployeeName,
                        TypeContractName = k.TypeContractName,
                        TypeRateName = k.TypeRateName,
                        PositionName = k.PositionName,
                        DepartmentName = k.DepartmentName,
                        CurrencyName = k.CurrencyName
                    }
                    );
            }
            SortedDescItems = new List<Contract>();
            foreach (var k in items.OrderByDescending(x => x.EmployeeName))
            {
                SortedDescItems.Add(
                    new Contract
                    {
                        ID = k.ID,
                        Salary = k.Salary,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        EmployeeName = k.EmployeeName,
                        TypeContractName = k.TypeContractName,
                        TypeRateName = k.TypeRateName,
                        PositionName = k.PositionName,
                        DepartmentName = k.DepartmentName,
                        CurrencyName = k.CurrencyName
                    }
                    );
            }
        }
        public override void Add(Contract item)
        {
            mobileHRServices.AddContract(new AddContractRequest(new Contracts
            {
                EmployeeId = item.EmployeeId,
                CurrencyId = item.CurrencyId,
                Salary = item.Salary,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,               
                DepartmentId = item.DepartmentId,
                TypeContractsID = item.DepartmentId,
                TerminationWayId = item.TerminationWayId,
                TypeRateId = item.TypeRateId,
                PositionId = item.PositionId,
               
            }
                ));

        }

        public override Contract Find(Contract item)
        {
            return items.Where((Contract arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Contract Find(int id)
        {
            return items.Where((Contract arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Contract> SearchItems(string searchItem)
        {
            SearchList = new List<Contract>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.EmployeeName.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Contract
                        {
                            ID = k.ID,
                            Salary = k.Salary,
                            DateFrom = k.DateFrom,
                            DateTo = k.DateTo,
                            EmployeeName = k.EmployeeName,
                            TypeContractName = k.TypeContractName,
                            TypeRateName = k.TypeRateName,
                            PositionName = k.PositionName,
                            DepartmentName = k.DepartmentName,
                            CurrencyName = k.CurrencyName
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Contract item)
        {
            mobileHRServices.UpdateContract(new UpdateContractRequest(new Contracts
            {              
                ID = item.ID,
                CurrencyId = item.CurrencyId,
                DepartmentId = item.DepartmentId,
                EmployeeId = item.EmployeeId,
                TerminationWayId = item.TerminationWayId,
                PositionId = item.PositionId,
                TypeContractsID = item.TypeContractsID,
                TypeRateId = item.TypeRateId,
                Salary = item.Salary,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                
            }));
        }
    }
}
