using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewGenderViewModel : ANewItemViewModel<Gender>
    {
       
        private string _value;
       

        public NewGenderViewModel():base()
        {
           
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_value);
                
        }

        public string Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
        public override Gender SetItem()
        {
            Gender newItem = new Gender()
            {
                ID = 4,
                Value = Value,

            };
            return newItem;
        }
    }
}
