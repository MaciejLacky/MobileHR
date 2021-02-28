using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class TerminationWaysViewModel : AItemsViewModel<TerminationWay>
    {
        public TerminationWaysViewModel()
        {
            Title = "Sposoby wypowiedzenia";
        }
        public override void GoToAddPage()
        {
           
            Shell.Current.GoToAsync(nameof(NewTerminationWayPage));
        }

        public override void GoToEditPage(TerminationWay item)
        {
            Messenger.Default.Send(item);
        }
    }
}
