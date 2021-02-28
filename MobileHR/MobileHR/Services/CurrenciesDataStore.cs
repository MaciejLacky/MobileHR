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
    public class CurrenciesDataStore : ItemDataStore<Currency>
    {
       

        public CurrenciesDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<CurrenciesForView> listaKFV = _MobileHRServices.GetCurrencies(null).GetCurrenciesResult.ToList();
            items = new List<Currency>();

            foreach (var k in listaKFV)
            {
                items.Add(new Currency
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<Currency>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new Currency
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<Currency>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new Currency
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
        }
        public override void Add(Currency item)
        {
            mobileHRServices.AddCurrency(new  AddCurrencyRequest(new Currencies
            {
                Value = item.Value
            })) ;

        }

        public override Currency Find(Currency item)
        {
            return items.Where((Currency arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Currency Find(int id)
        {
            return items.Where((Currency arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Currency> SearchItems(string searchItem)
        {
            SearchList = new List<Currency>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Currency
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Currency item)
        {
            mobileHRServices.UpdateCurrency(new UpdateCurrencyRequest(new Currencies
            {
                ID = item.ID,              
                Value = item.Value,
            }));
        }
    }
}
