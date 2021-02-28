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
    public class GendersViewModel : AItemsViewModel<Gender>
    {
     
        public GendersViewModel()
        {
            Title = "Płeć";
           
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewGenderPage));
        }

        public override void GoToEditPage(Gender item)
        {
            Messenger.Default.Send(item);
        }
    }
}
