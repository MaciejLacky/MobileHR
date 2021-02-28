using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class EmploymentHistoryViewModel : AItemsViewModel<EmploymentHist>
    {
        public EmploymentHistoryViewModel()
        {
            Title = "Historia zatrudnienia";
        }
        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewEmploymentHistoryPage));
        }

        public override void GoToEditPage(EmploymentHist item)
        {
            Messenger.Default.Send(item);
        }
    }
}
