using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewTypeRateViewModel : ANewItemViewModel<TypeRate>
    {
        private string _value;


        public NewTypeRateViewModel() : base()
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

        public override TypeRate SetItem()
        {
            TypeRate newItem = new TypeRate()
            {
                ID = 1,
                Value = Value,
            };
            return newItem;
        }
    }
}
