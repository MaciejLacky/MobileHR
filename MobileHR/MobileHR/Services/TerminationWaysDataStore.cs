using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class TerminationWaysDataStore : ItemDataStore<TerminationWay>
    {
        public TerminationWaysDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<TerminationWaysForView> listaKFV = _MobileHRServices.GetTerminationWays(null).GetTerminationWaysResult.ToList();
            
            items = new List<TerminationWay>();

            foreach (var k in listaKFV)
            {
                items.Add(new TerminationWay
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<TerminationWay>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new TerminationWay
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<TerminationWay>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new TerminationWay
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }

        }
        public override void Add(TerminationWay item)
        {
            mobileHRServices.AddTerminationWay(new AddTerminationWayRequest (new TerminationWays
            {
                Value = item.Value
            }));

        }
        public override TerminationWay Find(TerminationWay item)
        {
            return items.Where((TerminationWay arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override TerminationWay Find(int id)
        {
            return items.Where((TerminationWay arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<TerminationWay> SearchItems(string searchItem)
        {
            SearchList = new List<TerminationWay>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new TerminationWay
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(TerminationWay item)
        {
            throw new NotImplementedException();
        }
    }
}
