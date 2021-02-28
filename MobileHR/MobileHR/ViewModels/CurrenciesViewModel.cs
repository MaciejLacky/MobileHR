using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Services;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    class CurrenciesViewModel : AItemsViewModel<Currency>
    {
       

        public CurrenciesViewModel()
        {
            Title = "Waluty";
           
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewCurrencyPage));
        }

        public override void GoToEditPage(Currency item)
        {
            Messenger.Default.Send(item);
        }
    }
}
