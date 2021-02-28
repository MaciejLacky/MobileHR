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
    public class PositionsViewModel : AItemsViewModel<Position>
    {
       
        public PositionsViewModel()
        {
            Title = "Stanowisko";
           
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewPositionPage));
        }

        public override void GoToEditPage(Position item)
        {
            Messenger.Default.Send(item);
        }
    }
}
