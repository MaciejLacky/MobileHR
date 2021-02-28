using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class TypeContractsViewModel : AItemsViewModel<TypeContract>
    {
        public TypeContractsViewModel()
        {
            Title = "Typ umowy";
        }
        public override void GoToAddPage()
        {
            //Stworzyć widok w Views
            Shell.Current.GoToAsync(nameof(NewTypeContractPage));
        }

        public override void GoToEditPage(TypeContract item)
        {
            Messenger.Default.Send(item);
        }
    }
}
