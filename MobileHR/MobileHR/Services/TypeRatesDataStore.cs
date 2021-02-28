using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class TypeRatesDataStore : ItemDataStore<TypeRate>
    {
        public TypeRatesDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<TypeRatesForView> listaKFV = _MobileHRServices.GetTyperates(null).GetTyperatesResult.ToList();
            items = new List<TypeRate>();

            foreach (var k in listaKFV)
            {
                items.Add(new TypeRate
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<TypeRate>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new TypeRate
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<TypeRate>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new TypeRate
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
        }

        public override void Add(TypeRate item)
        {
            mobileHRServices.AddTypeRate(new AddTypeRateRequest(new TypeRates
            {
                Value = item.Value
            }));
        }
        public override TypeRate Find(TypeRate item)
        {
            return items.Where((TypeRate arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override TypeRate Find(int id)
        {
            return items.Where((TypeRate arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<TypeRate> SearchItems(string searchItem)
        {
            SearchList = new List<TypeRate>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new TypeRate
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(TypeRate item)
        {
            throw new NotImplementedException();
        }
    }
}
