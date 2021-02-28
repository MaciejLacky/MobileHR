using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class EmploymentHistoryEducationViewModel : AItemsViewModel<EmploymentHistEdu>
    {
        public EmploymentHistoryEducationViewModel()
        {
            Title = "Historia wykształcenia";
        }
        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewEmploymentHistoryEducationPage));
        }

        public override void GoToEditPage(EmploymentHistEdu item)
        {
            Messenger.Default.Send(item);
        }
    }
}
