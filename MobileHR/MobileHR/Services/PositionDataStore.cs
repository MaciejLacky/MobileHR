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
    public class PositionDataStore : ItemDataStore<Position>
    {
        

        public PositionDataStore()
        {
            var _MobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();

            List<PositionsForView> listaKFV = _MobileHRServices.GetPositions(null).GetPositionsResult.ToList();
            items = new List<Position>();

            foreach (var k in listaKFV)
            {
                items.Add(new Position
                {
                    ID = k.ID,
                    Name = k.Name,
                    MaxSalary = k.MaxSalary,
                    MinSalary = k.MinSalary,
                }
                    );
            }
            SortedAscItems = new List<Position>();
            foreach (var k in items.OrderBy(x => x.Name))
            {
                SortedAscItems.Add(
                    new Position
                    {
                        ID = k.ID,
                        Name = k.Name,
                        MaxSalary = k.MaxSalary,
                        MinSalary = k.MinSalary,
                    }
                    );
            }
            SortedDescItems = new List<Position>();
            foreach (var k in items.OrderByDescending(x => x.Name))
            {
                SortedDescItems.Add(
                    new Position
                    {
                        ID = k.ID,
                        Name = k.Name,
                        MaxSalary = k.MaxSalary,
                        MinSalary = k.MinSalary,
                    }
                    );
            }
        }
        public override void Add(Position item)
        {
            mobileHRServices.AddPosition(new AddPositionRequest(new Positions
            {
                Name = item.Name,
                MaxSalary = item.MaxSalary,
                MinSalary = item.MinSalary,
                
            }));
        }
        public override Position Find(Position item)
        {
            return items.Where((Position arg) => arg.ID == item.ID).FirstOrDefault();
        }

        public override Position Find(int id)
        {
            return items.Where((Position arg) => arg.ID == id).FirstOrDefault();
        }

        public override List<Position> SearchItems(string searchItem)
        {
            SearchList = new List<Position>();

            if (searchItem != null)
            {

                foreach (var k in items.Where(x => x.Name.StartsWith(searchItem)))
                {
                    SearchList.Add(
                        new Position
                        {
                            ID = k.ID,
                            Name = k.Name,
                            MaxSalary = k.MaxSalary,
                            MinSalary = k.MinSalary,
                        }
                        );
                }

            }
            return SearchList;
        }

        public override void Update(Position item)
        {
            mobileHRServices.UpdatePosition(new UpdatePositionRequest(new Positions
            {
                ID = item.ID,
                Name = item.Name,
                MaxSalary = item.MaxSalary,
                MinSalary = item.MinSalary,
            }));
        }
    }
}
