using ServiceReferenceMobileHR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileHR.Services
{
    public abstract class ItemDataStore<T> : IDataStore<T>
    {
        public IServiceMobileHR mobileHRServices { get; set; }
        public List<T> items;
        public List<T> SortedAscItems;
        public List<T> SortedDescItems;
        public List<T> SearchList;
        public ItemDataStore()
        {
            mobileHRServices = DependencyService.Get<ServiceReferenceMobileHR.IServiceMobileHR>();
        }
        public async Task<bool> AddItemAsync(T item)
        {
            Add(item);            
            items.Add(item);
            return await Task.FromResult(true);
        }
        public abstract T Find(T item);
        public abstract T Find(int id);

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = Find(id);
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }
        public abstract List<T> SearchItems(string searchItem);
        public abstract void Add(T item);
        public abstract void Update(T item);
        public async Task<T> GetItemAsync(int id)
        {
            return await Task.FromResult(Find(id));
        }

        public async Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            Update(item);
            var oldItem = Find(item);
            items.Remove(oldItem);
            items.Add(item);
            return await Task.FromResult(true);
        }
        public async Task<IEnumerable<T>> GetSortedAscItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(SortedAscItems);
        }
        public async Task<IEnumerable<T>> GetSortedDescItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(SortedDescItems);
        }
        public async Task<IEnumerable<T>> SearchItemsAsync(string text, bool forceRefresh = false)
        {
            return await Task.FromResult(SearchItems(text));
        }
    }
}
