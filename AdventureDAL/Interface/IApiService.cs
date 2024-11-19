namespace AdventureDAL.Interface
{
    public interface IApiService
    {
        Task<T> GetAsync<T>(string url);
        Task<T> GetByIdAsync<T>(string url, int id);
        Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest request);
        Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest request);
        Task DeleteAsync(string url);
    }
}
