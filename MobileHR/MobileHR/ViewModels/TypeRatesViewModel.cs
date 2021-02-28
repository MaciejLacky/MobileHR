using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class TypeRatesViewModel : AItemsViewModel<TypeRate>
    {
        public TypeRatesViewModel()
        {
            Title = "Stawki";
        }
        public override void GoToAddPage()
        {
            //Stworzyć widok w Views
            Shell.Current.GoToAsync(nameof(NewTypeRatePage));
        }

        public override void GoToEditPage(TypeRate item)
        {
            throw new NotImplementedException();
        }
    }
}
