using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    class NewPermissionViewModel : ANewItemViewModel<Permission>
    {
        private bool showEmployee;
        private bool editEmployee;
        public NewPermissionViewModel():base()
        {

        }

        public bool ShowEmployee
        {
            get => showEmployee;
            set => showEmployee = value;
        }
        public bool EditEmployee
        {
            get => editEmployee;
            set => editEmployee = value;
        }

        public override bool ValidateSave()
        {
            //zrobić walidacje
            throw new NotImplementedException();
        }

        public override Permission SetItem()
        {
            Permission newItem = new Permission
            {
                UserId = 1,
                ShowEmployees = true,
                EditEmployees = true,
            };
            return newItem;
        }

       
    }
}
