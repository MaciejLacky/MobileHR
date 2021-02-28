using MobileHR.Models;
using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public class NewPositionViewModel : ANewItemViewModel<Position>
    {
        
        private decimal? maxValue;
        private decimal? minValue;
        private string name;


        public NewPositionViewModel():base()
        {
           
        }

        public override bool ValidateSave()
        {

           // tu wprowadzićg walidacje
                return true;
               
        }

        public decimal? MaxValue
        {
            get => maxValue;
            set => SetProperty(ref maxValue, value);
        }
        public decimal? MinValue
        {
            get => minValue;
            set => SetProperty(ref minValue, value);
        }
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public override Position SetItem()
        {
            Position newItem = new Position()
            {
                ID = 1,
                MaxSalary = MaxValue,
                MinSalary = MinValue,
                Name = Name,

            };
            return newItem;
        }
    }
}
