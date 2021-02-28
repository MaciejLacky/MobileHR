using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileHR.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(int id);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> GetSortedAscItemsAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> GetSortedDescItemsAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> SearchItemsAsync(string text, bool forceRefresh = false);
    }
}
