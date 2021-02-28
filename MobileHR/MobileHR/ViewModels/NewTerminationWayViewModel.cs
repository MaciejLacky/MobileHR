using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.ViewModels
{
    public class NewTerminationWayViewModel : ANewItemViewModel<TerminationWay>
    {
        private string _value;


        public NewTerminationWayViewModel() : base()
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

        public override TerminationWay SetItem()
        {
            TerminationWay newItem = new TerminationWay()
            {
                ID = 1,
                Value = Value,
            };
            return newItem;
        }
    }
}
