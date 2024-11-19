using AdventureBUS.Serivces.Interface;
using AdventureBUS.ViewModel.ParticipantInteraction;
using AdventureDAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBUS.Serivces.Implement
{
    public class ParticipantInteractionService : IParticipantInteractionService
    {
        private readonly IApiService _apiService;
        private readonly string _apiUrl = "participant-interactions";

        public ParticipantInteractionService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<ParticipantInteractionVM>> GetAllInteractionsAsync()
        {
            return await _apiService.GetAsync<List<ParticipantInteractionVM>>(_apiUrl);
        }

        public async Task<ParticipantInteractionVM> GetInteractionByIdAsync(int id)
        {
            return await _apiService.GetByIdAsync<ParticipantInteractionVM>(_apiUrl, id);
        }

        public async Task<ParticipantInteractionVM> CreateInteractionAsync(CreateParticipantInteractionVM model)
        {
            return await _apiService.PostAsync<CreateParticipantInteractionVM, ParticipantInteractionVM>(_apiUrl, model);
        }

        public async Task<ParticipantInteractionVM> UpdateInteractionAsync(int id, UpdateParticipantInteractionVM model)
        {
            return await _apiService.PutAsync<UpdateParticipantInteractionVM, ParticipantInteractionVM>($"{_apiUrl}/{id}", model);
        }

        public async Task DeleteInteractionAsync(int id)
        {
            await _apiService.DeleteAsync($"{_apiUrl}/{id}");
        }
    }
}
