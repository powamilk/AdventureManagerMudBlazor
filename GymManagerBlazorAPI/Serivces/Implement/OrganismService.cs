using AdventureManagement.API.ViewModel.OrganismViewModel;
using AdventureManagerBlazorAPI.Serivces.Interface;
using GymManagerBlazorAPI.Serivces.Interface;

namespace AdventureManagerBlazorAPI.Serivces.Implement
{
    public class OrganismService : IOrganismService
    {
        private readonly IApiService _apiService;
        private readonly string _apiUrl = "organisms"; 

        public OrganismService(IApiService apiService)
        {
            _apiService = apiService;
        }
        public async Task<List<OrganismVM>> GetAllOrganismsAsync()
        {
            return await _apiService.GetAsync<List<OrganismVM>>(_apiUrl);
        }
        public async Task<OrganismVM> GetOrganismByIdAsync(int id)
        {
            return await _apiService.GetByIdAsync<OrganismVM>(_apiUrl, id);
        }
        public async Task<OrganismVM> CreateOrganismAsync(CreateOrganismVM model)
        {
            return await _apiService.PostAsync<CreateOrganismVM, OrganismVM>(_apiUrl, model);
        }
        public async Task<OrganismVM> UpdateOrganismAsync(int id, UpdateOrganismVM model)
        {
            return await _apiService.PutAsync<UpdateOrganismVM, OrganismVM>($"{_apiUrl}/{id}", model);
        }
        public async Task DeleteOrganismAsync(int id)
        {
            await _apiService.DeleteAsync($"{_apiUrl}/{id}");
        }
    }
}
