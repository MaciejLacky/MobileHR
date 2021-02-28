using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class EmploymentHistDataStore : ItemDataStore<EmploymentHist>
    {
        public EmploymentHistDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<EmploymentHistoryForView> listaKFV = _MobileHRServices.GetEmploymentHistories(null).GetEmploymentHistoriesResult.ToList();
            items = new List<EmploymentHist>();

            foreach (var k in listaKFV)
            {
                items.Add(new EmploymentHist
                {
                    ID = k.ID,                    
                    DateFrom = k.DateFrom,
                    DateTo = k.DateTo,
                    Adress = k.Adress,
                    EmployerName = k.EmployerName,
                    PhoneNumber = k.PhoneNumber,
                    EmployeeName = k.EmployeeName,
                    TerminationWayName = k.TerminationWayName,
                    TypeContractName = k.TypeContractName,
                    Comments = k.Comments
  
                }
                    );
            }
            SortedAscItems = new List<EmploymentHist>();
            foreach (var k in items.OrderBy(x => x.EmployeeName))
            {
                SortedAscItems.Add(
                    new EmploymentHist
                    {
                        ID = k.ID,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        Adress = k.Adress,
                        EmployerName = k.EmployerName,
                        PhoneNumber = k.PhoneNumber,
                        EmployeeName = k.EmployeeName,
                        TerminationWayName = k.TerminationWayName,
                        TypeContractName = k.TypeContractName,
                        Comments = k.Comments
                    }
                    );
            }
            SortedDescItems = new List<EmploymentHist>();
            foreach (var k in items.OrderByDescending(x => x.EmployeeName))
            {
                SortedDescItems.Add(
                    new EmploymentHist
                    {
                        ID = k.ID,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        Adress = k.Adress,
                        EmployerName = k.EmployerName,
                        PhoneNumber = k.PhoneNumber,
                        EmployeeName = k.EmployeeName,
                        TerminationWayName = k.TerminationWayName,
                        TypeContractName = k.TypeContractName,
                        Comments = k.Comments
                    }
                    );
            }

        }
        public override void Add(EmploymentHist item)
        {
            mobileHRServices.AddEmploymentHistory(new AddEmploymentHistoryRequest(new EmploymentHistory
            {
                ID = item.ID,
                EmployeeId = item.EmployeeId,
                EmployerName = item.EmployerName,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                Adress = item.Adress,
                PhoneNumber = item.PhoneNumber,
                Comments = item.Comments,
                TerminationWayId = item.TerminationWayId,
                TypeContractId = item.TypeContractId
            }));
        }

        public override EmploymentHist Find(EmploymentHist item)
        {
            return items.Where((EmploymentHist arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override EmploymentHist Find(int id)
        {
            return items.Where((EmploymentHist arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<EmploymentHist> SearchItems(string searchItem)
        {
            SearchList = new List<EmploymentHist>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.EmployeeName.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new EmploymentHist
                        {
                            ID = k.ID,
                            DateFrom = k.DateFrom,
                            DateTo = k.DateTo,
                            Adress = k.Adress,
                            EmployerName = k.EmployerName,
                            PhoneNumber = k.PhoneNumber,
                            EmployeeName = k.EmployeeName,
                            TerminationWayName = k.TerminationWayName,
                            TypeContractName = k.TypeContractName,
                            Comments = k.Comments
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(EmploymentHist item)
        {
            mobileHRServices.UpdateEmpHist(new UpdateEmpHistRequest(new EmploymentHistory
            {                
                ID = item.ID,
                EmployeeId = item.EmployeeId,
                TerminationWayId = item.TerminationWayId,
                TypeContractId = item.TypeContractId,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                Adress = item.Adress,
                Comments = item.Comments,
                EmployerName = item.EmployerName,
                PhoneNumber = item.PhoneNumber,
                
            }));
        }
    }
}
