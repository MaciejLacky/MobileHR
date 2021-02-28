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
    public class EmployeesViewModel : AItemsViewModel<Employee>
    {
        #region Fields
       
        #endregion
        #region Constructor
        public EmployeesViewModel()
        {
            Title = "Pracownicy";
           
        }
        #endregion
       
       
        #region Helpers
       

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(NewEmployeePage));
        }

        public override  void GoToEditPage(Employee id)
        {
            Messenger.Default.Send(id);
         
        }

        #endregion

    }
}
