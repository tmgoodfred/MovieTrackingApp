using MovieTrackingApp.API_and_DB_Calls;
using MovieTrackingApp.Models;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace MovieTrackingApp.Screens
{
    public partial class MainScreen : Form
    {
        private readonly DBCalls _dbCalls;
        private readonly string _userId;

        public MainScreen(DBCalls dbCalls, string userId)
        {
            InitializeComponent();
            _dbCalls = dbCalls;
            _userId = userId;

            LoadUserMovies();
        }

        private void LoadUserMovies()
        {
            List<UserMovie> userMovies = _dbCalls.GetUserMovies(_userId);

            var watchlistMovies = userMovies.Where(m => !m.Watched).ToList();
            var watchedMovies = userMovies.Where(m => m.Watched).ToList();

            PopulateDataGridView(watchlistDataGrid, watchlistMovies);
            PopulateDataGridView(watchedDataGrid, watchedMovies);
        }

        private void PopulateDataGridView(DataGridView dataGridView, List<UserMovie> movies)
        {
            var movieData = movies.Select(m => new
            {
                m.MovieId,
                Title = GetMovieTitle(m.MovieId), // You'll need to implement this method
                m.DateAdded,
                m.Rating
            }).ToList();

            dataGridView.DataSource = movieData;
            dataGridView.AutoResizeColumns();
        }

        private string GetMovieTitle(int movieId)
        {
            // Implement this method to fetch the movie title from your database or API
            // For now, we'll return a placeholder
            return $"Movie {movieId}";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text.Length > 0)
            {
                SearchMoviesScreen searchScreen = new SearchMoviesScreen(searchTxt.Text);
                searchScreen.Show();
            }
            else 
            {
                MessageBox.Show("Please enter a search query.");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Implement logout functionality
        }
    }
}