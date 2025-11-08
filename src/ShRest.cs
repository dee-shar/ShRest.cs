using System.Net.Http;

namespace ShRestApi
{
    public class ShRest
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://shrekofficial.com";
        public ShRest()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetMovies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/movies");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRandomQuote()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/quotes/random");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovie(int movieId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{movieId}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovieCast(int movieId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{movieId}/top/cast");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovieQuotes(int movieId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{movieId}/quotes");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovieRandomQuote(int movieId)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{movieId}/quotes/random");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
