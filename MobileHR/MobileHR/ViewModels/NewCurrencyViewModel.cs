using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewCurrencyViewModel : ANewItemViewModel<Currency>
    {
       
        private string _value;
       

        public NewCurrencyViewModel():base()
        {
           
        }

       public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_value)
                && !String.IsNullOrWhiteSpace(_value);
        }

        public string Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        public override Currency SetItem()
        {
            Currency newItem = new Currency()
            {
                ID = 1,
                Value = Value,
            };
            return newItem;
        }
    }
}
