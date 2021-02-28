using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class EmploymentHistEduDataStore : ItemDataStore<EmploymentHistEdu>
    {
        public EmploymentHistEduDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<EmploymentHistoryEducationForView> listaKFV = _MobileHRServices.GetEmploymentHistoryEducations(null).GetEmploymentHistoryEducationsResult.ToList();
            items = new List<EmploymentHistEdu>();

            foreach (var k in listaKFV)
            {
                items.Add(new EmploymentHistEdu
                {
                    ID = k.ID,
                    DateFrom = k.DateFrom,
                    DateTo = k.DateTo,
                    CertificateName = k.CertificateName,
                    SchoolAdress = k.SchoolAdress,
                    SchoolName = k.SchoolName,
                    Comments = k.Comments,
                    EmployeeName = k.EmployeeName

                }
                    );
            }
            SortedAscItems = new List<EmploymentHistEdu>();
            foreach (var k in items.OrderBy(x => x.EmployeeName))
            {
                SortedAscItems.Add(
                    new EmploymentHistEdu
                    {
                        ID = k.ID,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        CertificateName = k.CertificateName,
                        SchoolAdress = k.SchoolAdress,
                        SchoolName = k.SchoolName,
                        Comments = k.Comments,
                        EmployeeName = k.EmployeeName
                    }
                    );
            }
            SortedDescItems = new List<EmploymentHistEdu>();
            foreach (var k in items.OrderByDescending(x => x.EmployeeName))
            {
                SortedDescItems.Add(
                    new EmploymentHistEdu
                    {
                        ID = k.ID,
                        DateFrom = k.DateFrom,
                        DateTo = k.DateTo,
                        CertificateName = k.CertificateName,
                        SchoolAdress = k.SchoolAdress,
                        SchoolName = k.SchoolName,
                        Comments = k.Comments,
                        EmployeeName = k.EmployeeName
                    }
                    );
            }
        }
        public override void Add(EmploymentHistEdu item)
        {
            mobileHRServices.AddEmploymentHistoryEdu(new AddEmploymentHistoryEduRequest(new EmploymentHistoryEducation
            {
                ID = item.ID,
                EmployeeId = item.EmployeeId,
                SchoolName = item.SchoolName,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                SchoolAdress = item.SchoolAdress,               
                Comments = item.Comments,
                CertificateName = item.CertificateName
                
            }));
        }

        public override EmploymentHistEdu Find(EmploymentHistEdu item)
        {
            return items.Where((EmploymentHistEdu arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override EmploymentHistEdu Find(int id)
        {
            return items.Where((EmploymentHistEdu arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<EmploymentHistEdu> SearchItems(string searchItem)
        {
            SearchList = new List<EmploymentHistEdu>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.EmployeeName.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new EmploymentHistEdu
                        {
                            ID = k.ID,
                            DateFrom = k.DateFrom,
                            DateTo = k.DateTo,
                            CertificateName = k.CertificateName,
                            SchoolAdress = k.SchoolAdress,
                            SchoolName = k.SchoolName,
                            Comments = k.Comments,
                            EmployeeName = k.EmployeeName
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(EmploymentHistEdu item)
        {
            mobileHRServices.UpdateEmpHistEdu(new UpdateEmpHistEduRequest(new EmploymentHistoryEducation
            {
                ID = item.ID,
                EmployeeId = item.EmployeeId,              
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                SchoolAdress = item.SchoolAdress,
                Comments = item.Comments,
                SchoolName = item.SchoolName,
                CertificateName = item.CertificateName,
                

            }));
        }
    }
}
