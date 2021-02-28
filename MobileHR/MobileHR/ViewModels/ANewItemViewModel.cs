using MobileHR.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public abstract class ANewItemViewModel<T> : BaseViewModel
    {
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();


        public ANewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            UpdateCommand = new Command(OnUpdate);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        public abstract bool ValidateSave();



        public Command UpdateCommand { get; }
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        public abstract T SetItem();
        private async void OnSave()
        {


            await DataStore.AddItemAsync(SetItem());

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        private async void OnUpdate()
        {
           

             await DataStore.UpdateItemAsync(SetItem());

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
