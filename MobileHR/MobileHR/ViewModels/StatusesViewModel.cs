using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class StatusesViewModel : AItemsViewModel<Status>
    {
        public StatusesViewModel()
        {
            Title = "Statusy";
        }
        public override void GoToAddPage()
        {
            
            Shell.Current.GoToAsync(nameof(NewStatusPage));
        }

        public override void GoToEditPage(Status item)
        {
            Messenger.Default.Send(item);
        }
    }
}
