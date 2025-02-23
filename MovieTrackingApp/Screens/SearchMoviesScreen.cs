using MovieTrackingApp.Models;
using MovieTrackingApp.API_Calls;
using Microsoft.Extensions.Configuration;

namespace MovieTrackingApp.Screens
{
    public partial class SearchMoviesScreen : Form
    {
        private readonly TMDBApiCall _apiCalls;
        private string _currentSearchQuery;

        public SearchMoviesScreen(string movieName)
        {
            InitializeComponent();
            _apiCalls = new TMDBApiCall();
            _currentSearchQuery = movieName;

            searchTxt.Text = movieName;
            SearchMovies(movieName);
        }

        private async void SearchMovies(string query)
        {
            try
            {
                List<Movie> searchResults = await _apiCalls.SearchMoviesAsync(query);
                PopulateDataGridView(searchResults);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = searchTxt.Text.Trim();
            if (!string.IsNullOrEmpty(query))
            {
                _currentSearchQuery = query;
                SearchMovies(query);
            }
            else
            {
                MessageBox.Show("Please enter a search query.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopulateDataGridView(List<Movie> movies)
        {
            searchedMoviesDataGrid.DataSource = movies;
            searchedMoviesDataGrid.AutoResizeColumns();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewDetailsBtn_Click(object sender, EventArgs e)
        {

        }

        private void addToWatchlistBtn_Click(object sender, EventArgs e)
        {

        }

        private void addToWatchedBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
