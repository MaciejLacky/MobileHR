using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class EditPositionViewModel : ANewItemViewModel<Position>
    {
        #region Fields
        private string itemId;
        private string _value;
        private decimal? _maxSalary;
        private decimal? _minSalary;
        #endregion
        #region Constructor
        public EditPositionViewModel() : base()
        {

        }
        #endregion
        public override bool ValidateSave()
        {
            return true;

        }
        #region Properties

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }
        public string Name
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
        public decimal? MaxSalary
        {
            get => _maxSalary;
            set => SetProperty(ref _maxSalary, value);
        }
        public decimal? MinSalary
        {
            get => _minSalary;
            set => SetProperty(ref _minSalary, value);
        }
        #endregion
        #region Helpers
        public override Position SetItem()
        {
            Position newItem = new Position()
            {
                ID = Convert.ToInt32(itemId),
                Name = Name,
                MinSalary = MinSalary,
                MaxSalary = MaxSalary,

            };
            return newItem;
        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(Convert.ToInt32(itemId));
                Name = item.Name;
                MaxSalary = item.MaxSalary;
                MinSalary = item.MinSalary;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        #endregion
    }
}
