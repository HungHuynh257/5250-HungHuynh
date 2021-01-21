using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Aegis Shield", Description="A Hero's Relic that blocks any incomming damange.", Value=5  },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Thyrsus ", Description="Double the range of magic user.",Value=7 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Mango", Description="Taste good +50 mana", Value=1 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Broken Ring", Description="It actually does nothing. Worthless", Value=0 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Speed Carrot", Description="You think you are faster but no, everyone else is just hungry.", Value=2 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Golden Apple", Description="In Emergency, a decoration can be used as a weapon.", Value=3 }

            };
        }

        public async Task<bool> AddItemAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}