using AdventureBUS.ViewModel.GuideViewModel;

namespace AdventureBUS.Serivces.Interface
{
    public interface IGuideService
    {
        Task<List<GuideVM>> GetAllGuidesAsync();
        Task<GuideVM> GetGuideByIdAsync(int id);
        Task<GuideVM> CreateGuideAsync(CreateGuideVM model);
        Task<GuideVM> UpdateGuideAsync(int id, UpdateGuideVM model);
        Task DeleteGuideAsync(int id);
    }
}
