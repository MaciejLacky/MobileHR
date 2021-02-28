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
    public class DepartmentsDataStore : ItemDataStore<Department>
    {
       

        public DepartmentsDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<DepartmentsForView> listaKFV = _MobileHRServices.GetDepartments(null).GetDepartmentsResult.ToList();
            items = new List<Department>();

            foreach (var k in listaKFV)
            {
                items.Add(new Department
                {
                    ID = k.ID,
                    Name = k.Value,
                    Location = k.Location,
                    ManagerId = k.ManagerId,
                    ManagerName = k.ManagerName,

                }
                    ) ;
            }
            SortedAscItems = new List<Department>();
            foreach (var k in items.OrderBy(x => x.Name))
            {
                SortedAscItems.Add(
                    new Department
                    {
                        ID = k.ID,
                        Name = k.Name,
                        Location = k.Location,
                        ManagerId = k.ManagerId,
                        ManagerName = k.ManagerName,
                    }
                    );
            }
            SortedDescItems = new List<Department>();
            foreach (var k in items.OrderByDescending(x => x.Name))
            {
                SortedDescItems.Add(
                    new Department
                    {
                        ID = k.ID,
                        Name = k.Name,
                        Location = k.Location,
                        ManagerId = k.ManagerId,
                        ManagerName = k.ManagerName,
                    }
                    );
            }
        }
        public override void Add(Department item)
        {
            mobileHRServices.AddDepartment(new AddDepartmentRequest (new Departments
            {
                Name = item.Name,
                Location = item.Location,
                ManagerId = item.ManagerId,
                
                
            })) ;
        }

        public override Department Find(Department item)
        {
            return items.Where((Department arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Department Find(int id)
        {
            return items.Where((Department arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Department> SearchItems(string searchItem)
        {
            SearchList = new List<Department>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Name.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Department
                        {
                            ID = k.ID,
                            Name = k.Name,
                            Location = k.Location,
                            ManagerId = k.ManagerId,
                            ManagerName = k.ManagerName,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Department item)
        {
            mobileHRServices.UpdateDepartment(new UpdateDepartmentRequest(new Departments
            {               
                ID = item.ID,
                ManagerId = item.ManagerId,
                Location = item.Location,
                Name = item.Name,
                
            }));
        }
    }
}
