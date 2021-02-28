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
    public class GendersDataStore : ItemDataStore<Gender>
    {
        

        public GendersDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<GendersForView> listaKFV = _MobileHRServices.GetGenders(null).GetGendersResult.ToList();
            items = new List<Gender>();

            foreach (var k in listaKFV)
            {
                items.Add(new Gender
                {
                    ID = k.ID,
                    Value = k.Value,
                }
                    );
            }
            SortedAscItems = new List<Gender>();
            foreach (var k in items.OrderBy(x => x.Value))
            {
                SortedAscItems.Add(
                    new Gender
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
            SortedDescItems = new List<Gender>();
            foreach (var k in items.OrderByDescending(x => x.Value))
            {
                SortedDescItems.Add(
                    new Gender
                    {
                        ID = k.ID,
                        Value = k.Value,
                    }
                    );
            }
        }
        public override void Add(Gender item)
        {
            mobileHRServices.AddGender(new AddGenderRequest(new Genders
            {
                Value = item.Value
            }));
        }

        public override Gender Find(Gender item)
        {
            return items.Where((Gender arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Gender Find(int id)
        {
            return items.Where((Gender arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Gender> SearchItems(string searchItem)
        {
            SearchList = new List<Gender>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Value.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Gender
                        {
                            ID = k.ID,
                            Value = k.Value,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Gender item)
        {
            mobileHRServices.UpdateGender(new UpdateGenderRequest(new Genders
            {
                ID = item.ID,
                Value = item.Value,
            }));
        }
    }
}
