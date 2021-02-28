using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MobileHR.Models;
using MobileHR.Services;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewItemViewModel : ANewItemViewModel<Item>
    {
       
        private string text;
        private string description;

        public NewItemViewModel():base()
        {
           
        }

        public override  bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

       

       

        public override Item SetItem()
        {
            Item newItem = new Item()
            {
                Id = Convert.ToInt32(Guid.NewGuid().ToString()),
                Text = Text,
                Description = Description
            };
            return newItem;
        }
    }
}
