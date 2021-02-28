using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewTypeContractViewModel : ANewItemViewModel<TypeContract>
    {
        private string _value;


        public NewTypeContractViewModel() : base()
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

        public override TypeContract SetItem()
        {
            TypeContract newItem = new TypeContract()
            {
                ID = 1,
                Value = Value,
            };
            return newItem;
        }
    }
}
