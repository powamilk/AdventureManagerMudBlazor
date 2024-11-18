namespace GymManagerBlazorAPI.Serivces.Interface
{
    public interface IApiService
    {
        Task<TResponse> GetAsync<TResponse>(string url);
        Task<TResponse> GetByIdAsync<TResponse>(string url, int id);
        Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest model);
        Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest model);
        Task DeleteAsync(string url);
    }
}
