using AdventureBUS.ViewModel.OrganismViewModel;

namespace AdventureBUS.Serivces.Interface
{
    public interface IOrganismService
    {
        Task<List<OrganismVM>> GetAllOrganismsAsync();
        Task<OrganismVM> GetOrganismByIdAsync(int id);
        Task<OrganismVM> CreateOrganismAsync(CreateOrganismVM model);
        Task<OrganismVM> UpdateOrganismAsync(int id, UpdateOrganismVM model);
        Task DeleteOrganismAsync(int id);
    }
}
