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
    public class ContractsViewModel : AItemsViewModel<Contract>
    {
       
        public ContractsViewModel()
        {
            Title = "Umowy";
           
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewContractPage));
        }

        public override void GoToEditPage(Contract item)
        {
            Messenger.Default.Send(item);
        }
    }
}
