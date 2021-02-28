using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MobileHR.Models;
using MobileHR.Views;
using MobileHR.Services;

namespace MobileHR.ViewModels
{
    public class ItemsViewModel : AItemsViewModel<Item>
    {
        public ItemsViewModel()
        {
            Title = "Items";
          
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        public override void GoToEditPage(Item item)
        {
            throw new NotImplementedException();
        }
    }
}