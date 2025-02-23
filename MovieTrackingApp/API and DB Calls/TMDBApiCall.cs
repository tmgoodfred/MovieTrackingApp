using Microsoft.Extensions.Configuration;
using MovieTrackingApp.Models;
using Newtonsoft.Json.Linq;

namespace MovieTrackingApp.API_Calls
{
    public class TMDBApiCall
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://api.themoviedb.org/3";

        public TMDBApiCall()
        {
            _apiKey = Program.Configuration["TMDb:ApiKey"];
            _httpClient = new HttpClient();
        }

        public async Task<List<Movie>> SearchMoviesAsync(string query)
        {
            string url = $"{BaseUrl}/search/movie?api_key={_apiKey}&query={Uri.EscapeDataString(query)}";
            var response = await _httpClient.GetStringAsync(url);
            var json = JObject.Parse(response);

            var movies = new List<Movie>();
            foreach (var result in json["results"])
            {
                movies.Add(MapToMovie(result));
            }

            return movies;
        }

        public async Task<Movie> GetMovieDetailsAsync(int movieId)
        {
            string url = $"{BaseUrl}/movie/{movieId}?api_key={_apiKey}";
            var response = await _httpClient.GetStringAsync(url);
            var json = JObject.Parse(response);

            return MapToMovie(json);
        }

        private Movie MapToMovie(JToken movieData)
        {
            return new Movie
            {
                Id = (int)movieData["id"],
                Title = (string)movieData["title"],
                Overview = (string)movieData["overview"],
                ReleaseDate = DateTime.TryParse((string)movieData["release_date"], out var releaseDate) ? releaseDate : DateTime.MinValue,
                PosterPath = (string)movieData["poster_path"],
                VoteAverage = (double)movieData["vote_average"]
            };
        }
    }
}
