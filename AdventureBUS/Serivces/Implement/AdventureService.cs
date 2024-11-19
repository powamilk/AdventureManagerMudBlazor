using AdventureBUS.Serivces.Interface;
using AdventureBUS.ViewModel.AdventureViewModel;
using AdventureDAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBUS.Serivces.Implement
{
    public class AdventureService : IAdventureService
    {
        private readonly IApiService _apiService;
        private readonly string _apiUrl = "adventures";

        public AdventureService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<AdventureVM>> GetAllAdventuresAsync()
        {
            return await _apiService.GetAsync<List<AdventureVM>>(_apiUrl);
        }

        public async Task<AdventureVM> GetAdventureByIdAsync(int id)
        {
            return await _apiService.GetByIdAsync<AdventureVM>(_apiUrl, id);
        }

        public async Task<AdventureVM> CreateAdventureAsync(CreateAdventureVM model)
        {
            return await _apiService.PostAsync<CreateAdventureVM, AdventureVM>(_apiUrl, model);
        }

        public async Task<AdventureVM> UpdateAdventureAsync(int id, UpdateAdventureVM model)
        {
            return await _apiService.PutAsync<UpdateAdventureVM, AdventureVM>($"{_apiUrl}/{id}", model);
        }

        public async Task DeleteAdventureAsync(int id)
        {
            await _apiService.DeleteAsync($"{_apiUrl}/{id}");
        }
    }
}
