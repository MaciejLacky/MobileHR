using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewUserViewModel : ANewItemViewModel<User>
    {
        private string _lastName;
        private string _firstName;
        private string _emailAdres;
        private string _name;
        private string _password;
        private bool _isAdmin;


        public NewUserViewModel() : base()
        {

        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_lastName)
                && !String.IsNullOrWhiteSpace(_lastName);
        }

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }
        public string EmailAdres
        {
            get => _emailAdres;
            set => SetProperty(ref _emailAdres, value);
        }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public bool IsAdmin
        {
            get => _isAdmin;
            set => SetProperty(ref _isAdmin, value);
        }

        public override User SetItem()
        {
            User newItem = new User()
            {
                ID = 1,
                
            };
            return newItem;
        }
    }
}
