using MobileHR.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class EditCurrenciesViewModel: ANewItemViewModel<Currency>
    {
        #region Fields
        private string itemId;
        private string _value;
        #endregion
        #region Constructor
        public EditCurrenciesViewModel():base()
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
        public string Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
        #endregion
        #region Helpers
        public override Currency SetItem()
        {
            Currency newItem = new Currency()
            {
                ID = Convert.ToInt32(itemId),
                Value = Value,
            };
            return newItem;
        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(Convert.ToInt32(itemId));
                Value = item.Value;             
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        #endregion
    }
}
