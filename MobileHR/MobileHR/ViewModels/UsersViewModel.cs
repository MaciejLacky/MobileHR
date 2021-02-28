using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class UsersViewModel : AItemsViewModel<User>
    {
        public UsersViewModel()
        {
            Title = "Użytkownicy";
        }
        public override void GoToAddPage()
        {
            //Stworzyć widok w Views
            //Shell.Current.GoToAsync(nameof(NewUsersPage));
        }

        public override void GoToEditPage(User item)
        {
            throw new NotImplementedException();
        }
    }
}
