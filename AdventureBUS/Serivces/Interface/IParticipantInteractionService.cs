using AdventureBUS.ViewModel.ParticipantInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBUS.Serivces.Interface
{
    public interface IParticipantInteractionService
    {
        Task<List<ParticipantInteractionVM>> GetAllInteractionsAsync();
        Task<ParticipantInteractionVM> GetInteractionByIdAsync(int id);
        Task<ParticipantInteractionVM> CreateInteractionAsync(CreateParticipantInteractionVM model);
        Task<ParticipantInteractionVM> UpdateInteractionAsync(int id, UpdateParticipantInteractionVM model);
        Task DeleteInteractionAsync(int id);
    }
}
