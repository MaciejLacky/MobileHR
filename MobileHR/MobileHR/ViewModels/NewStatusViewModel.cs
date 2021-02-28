using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewStatusViewModel: ANewItemViewModel<Status>
    {
        private string _value;


        public NewStatusViewModel() : base()
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

        public override Status SetItem()
        {
           Status newItem = new Status()
            {
                ID = 1,
                Value = Value,
            };
            return newItem;
        }
    }
}
