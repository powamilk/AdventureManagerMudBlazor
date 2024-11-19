using AdventureBUS.Serivces.Interface;
using AdventureBUS.ViewModel.Participant;
using AdventureDAL.Interface;

namespace AdventureBUS.Serivces.Implement
{
    public class ParticipantService : IParticipantService
    {
        private readonly IApiService _apiService;
        private readonly string _apiUrl = "participants";

        public ParticipantService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<ParticipantVM>> GetAllParticipantsAsync()
        {
            return await _apiService.GetAsync<List<ParticipantVM>>(_apiUrl);
        }

        public async Task<ParticipantVM> GetParticipantByIdAsync(int id)
        {
            return await _apiService.GetByIdAsync<ParticipantVM>(_apiUrl, id);
        }

        public async Task<ParticipantVM> CreateParticipantAsync(ParticipantCreateVM model)
        {
            return await _apiService.PostAsync<ParticipantCreateVM, ParticipantVM>(_apiUrl, model);
        }

        public async Task<ParticipantVM> UpdateParticipantAsync(int id, ParticipantUpdateVM model)
        {
            return await _apiService.PutAsync<ParticipantUpdateVM, ParticipantVM>($"{_apiUrl}/{id}", model);
        }

        public async Task DeleteParticipantAsync(int id)
        {
            await _apiService.DeleteAsync($"{_apiUrl}/{id}");
        }
    }
}
