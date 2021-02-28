using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class PermissionsViewModel : AItemsViewModel<Permission>
    {
        public PermissionsViewModel()
        {
            Title = "Pozwolenia";
        }
        public override void GoToAddPage()
        {
            //stworzyć widok w Views
            //Shell.Current.GoToAsync(nameof(NewPermissionPage));
        }

        public override void GoToEditPage(Permission item)
        {
            throw new NotImplementedException();
        }
    }
}
