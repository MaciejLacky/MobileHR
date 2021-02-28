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
    public class DepartmentsViewModel : AItemsViewModel<Department>
    {
        
        public DepartmentsViewModel()
        {
            Title = "Działy";          
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewDepartmentPage));
        }

        public override void GoToEditPage(Department item)
        {
            Messenger.Default.Send(item);
        }
    }
}
