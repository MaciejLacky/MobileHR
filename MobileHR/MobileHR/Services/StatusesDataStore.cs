using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class StatusesDataStore : ItemDataStore<Status>
    {
        public StatusesDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<StatusesForView> listaKFV = _MobileHRServices.GetStatuses(null).GetStatusesResult.ToList();
            items = new List<Status>();

            foreach (var k in listaKFV)
            {
                items.Add(new Status
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<Status>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new Status
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<Status>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new Status
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }

        }
        public override void Add(Status item)
        {
            mobileHRServices.AddStatus(new AddStatusRequest(new Statuses 
            { 
                Value = item.Value
               
            }));

        }
        public override Status Find(Status item)
        {
            return items.Where((Status arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Status Find(int id)
        {
            return items.Where((Status arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Status> SearchItems(string searchItem)
        {
            SearchList = new List<Status>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Status
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Status item)
        {
            mobileHRServices.UpdateStatus(new UpdateStatusRequest(new Statuses
            {
                ID = item.ID,
                Value = item.Value,
            }));
        }
    }
}
