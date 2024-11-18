using AdventureManagement.API.ViewModel.GuideViewModel;
using GymManagerBlazorAPI.Serivces.Interface;

namespace GymManagerBlazorAPI.Serivces.Implement
{
    public class GuideService : IGuideService
    {
        private readonly IApiService _apiService;
        private readonly string _apiUrl = "guides";

        public GuideService(IApiService apiService)
        {
            _apiService = apiService;
        }
        public async Task<List<GuideVM>> GetAllGuidesAsync()
        {
            return await _apiService.GetAsync<List<GuideVM>>(_apiUrl);
        }
        public async Task<GuideVM> GetGuideByIdAsync(int id)
        {
            return await _apiService.GetByIdAsync<GuideVM>(_apiUrl, id);
        }

        public async Task<GuideVM> CreateGuideAsync(CreateGuideVM model)
        {
            return await _apiService.PostAsync<CreateGuideVM, GuideVM>(_apiUrl, model);
        }

        public async Task<GuideVM> UpdateGuideAsync(int id, UpdateGuideVM model)
        {
            return await _apiService.PutAsync<UpdateGuideVM, GuideVM>($"{_apiUrl}/{id}", model);
        }

        public async Task DeleteGuideAsync(int id)
        {
            await _apiService.DeleteAsync($"{_apiUrl}/{id}");
        }
    }
}
