using AdventureBUS.ViewModel.Participant;

namespace AdventureBUS.Serivces.Interface
{
    public interface IParticipantService
    {
        Task<List<ParticipantVM>> GetAllParticipantsAsync();
        Task<ParticipantVM> GetParticipantByIdAsync(int id);
        Task<ParticipantVM> CreateParticipantAsync(ParticipantCreateVM model);
        Task<ParticipantVM> UpdateParticipantAsync(int id, ParticipantUpdateVM model);
        Task DeleteParticipantAsync(int id);
    }
}
