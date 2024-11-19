using AdventureBUS.ViewModel.AdventureViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBUS.Serivces.Interface
{
    public interface IAdventureService
    {
        Task<List<AdventureVM>> GetAllAdventuresAsync();
        Task<AdventureVM> GetAdventureByIdAsync(int id);
        Task<AdventureVM> CreateAdventureAsync(CreateAdventureVM model);
        Task<AdventureVM> UpdateAdventureAsync(int id, UpdateAdventureVM model);
        Task DeleteAdventureAsync(int id);
    }
}
