using MobileHR.Models;
using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public class TypeContractDataStore : ItemDataStore<TypeContract>
    {
        public TypeContractDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<TypeContractsForView> listaKFV = _MobileHRServices.GetTypeContracts(null).GetTypeContractsResult.ToList();

            items = new List<TypeContract>();

            foreach (var k in listaKFV)
            {
                items.Add(new TypeContract
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<TypeContract>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new TypeContract
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<TypeContract>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new TypeContract
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
        }
        public override void Add(TypeContract item)
        {
            mobileHRServices.AddTypeContract(new AddTypeContractRequest(new TypeContracts
            {
                Value = item.Value
            }));
        }
        public override TypeContract Find(TypeContract item)
        {
            return items.Where((TypeContract arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override TypeContract Find(int id)
        {
            return items.Where((TypeContract arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<TypeContract> SearchItems(string searchItem)
        {
            SearchList = new List<TypeContract>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new TypeContract
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(TypeContract item)
        {
            mobileHRServices.UpdateTypeContract(new UpdateTypeContractRequest(new TypeContracts
            {
                ID = item.ID,
                Value = item.Value,
            }));
        }
    }
}
