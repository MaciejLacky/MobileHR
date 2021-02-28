using GalaSoft.MvvmLight.Messaging;
using MobileHR.Models;
using MobileHR.Services;
using MobileHR.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileHR.ViewModels
{
    public abstract class AItemsViewModel<T> : BaseViewModel
    {
        #region Fields
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();
        private T _selectedItem;
        private string _searchText;
        public ObservableCollection<T> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<T> ItemTapped { get; }
        public Command SortAscItemsCommand { get; }
        public Command SortDescItemsCommand { get; }
        public Command SearchItemsCommand { get; }
        #endregion
        #region Constructor
        public AItemsViewModel()
        {

            Items = new ObservableCollection<T>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<T>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
            SortAscItemsCommand = new Command(async () => await sortedAscList());
            SortDescItemsCommand = new Command(async () => await sortedDescList());
            SearchItemsCommand = new Command(async () => await searchList());

        }
        #endregion
        #region Properties
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                }
            }
        }
        #endregion
        #region Helpers
        async Task searchList()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.SearchItemsAsync(SearchText, true);

                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        async Task sortedAscList()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetSortedAscItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        async Task sortedDescList()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetSortedDescItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);

                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }

        }


        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = default(T);
        }

        public T SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        public abstract void GoToAddPage();
        public abstract void GoToEditPage(T item);

        public void OnAddItem(object obj)
        {
            GoToAddPage();
        }

        public void OnItemSelected(T item)
        {
            if (item == null)
                return;

            GoToEditPage(item);


            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
            // await Shell.Current.GoToAsync($"{nameof(EditEmployeePage)}?{nameof(EditEmployeeViewModel.ItemId)}={item}");
            //Messenger.Default.Send();

            // await Shell.Current.GoToAsync(nameof(NewEmployeePage));
        }
        #endregion


    }
}
