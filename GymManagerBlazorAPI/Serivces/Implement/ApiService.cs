using GymManagerBlazorAPI.Serivces.Interface;
using System.Net.Http.Json;

namespace GymManagerBlazorAPI.Serivces.Implement
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TResponse> GetAsync<TResponse>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            throw new HttpRequestException($"Error fetching data from {url}: {response.ReasonPhrase}");
        }
        public async Task<TResponse> GetByIdAsync<TResponse>(string url, int id)
        {
            var response = await _httpClient.GetAsync($"{url}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            throw new HttpRequestException($"Error fetching data from {url}/{id}: {response.ReasonPhrase}");
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest model)
        {
            var response = await _httpClient.PostAsJsonAsync(url, model);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            throw new HttpRequestException($"Error posting data to {url}: {response.ReasonPhrase}");
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest model)
        {
            var response = await _httpClient.PutAsJsonAsync(url, model);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TResponse>();
            }
            throw new HttpRequestException($"Error updating data to {url}: {response.ReasonPhrase}");
        }
        public async Task DeleteAsync(string url)
        {
            var response = await _httpClient.DeleteAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error deleting data from {url}: {response.ReasonPhrase}");
            }
        }
    }
}
