using System.Collections.ObjectModel;
using System.Windows.Input;
using TartuTouristGuide.Data;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    // ViewModel for the home screen: handles global progress and navigation
    public class HomeViewModel : BaseViewModel
    {
        private readonly VisitedPlacesService _visitedService;
        private int _visitedCount;
        private int _totalPlaces;
        private double _progressValue;
        private string _progressText = string.Empty;
        private string _visitedText = string.Empty;
        private Color _progressColor = Color.FromArgb("#3b82f6");
        private Color _progressBackgroundColor = Color.FromArgb("#eff6ff");
        private Color _progressTextColor = Color.FromArgb("#1e3a8a");

        // Stats per category shown on the home screen
        private string _historyStats = string.Empty;
        private string _relaxationStats = string.Empty;
        private string _entertainmentStats = string.Empty;
        private string _restaurantsStats = string.Empty;

        // Initializes commands and loads global place count
        public HomeViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;
            _totalPlaces = PlacesData.GetPlaces().Count;

            NavigateToCategoryCommand = new Command<string>(async (category) => await NavigateToCategory(category));
            NavigateToRewardsCommand = new Command(async () => await NavigateToRewards());
            NavigateToTartu101Command = new Command(async () => await NavigateToTartu101());

            RefreshProgress();
        }

        public int VisitedCount
        {
            get => _visitedCount;
            set => SetProperty(ref _visitedCount, value);
        }

        public int TotalPlaces
        {
            get => _totalPlaces;
            set => SetProperty(ref _totalPlaces, value);
        }

        public double ProgressValue
        {
            get => _progressValue;
            set => SetProperty(ref _progressValue, value);
        }

        public string ProgressText
        {
            get => _progressText;
            set => SetProperty(ref _progressText, value);
        }

        public string VisitedText
        {
            get => _visitedText;
            set => SetProperty(ref _visitedText, value);
        }

        public Color ProgressColor
        {
            get => _progressColor;
            set => SetProperty(ref _progressColor, value);
        }

        public Color ProgressBackgroundColor
        {
            get => _progressBackgroundColor;
            set => SetProperty(ref _progressBackgroundColor, value);
        }

        public Color ProgressTextColor
        {
            get => _progressTextColor;
            set => SetProperty(ref _progressTextColor, value);
        }

        public string HistoryStats
        {
            get => _historyStats;
            set => SetProperty(ref _historyStats, value);
        }

        public string RelaxationStats
        {
            get => _relaxationStats;
            set => SetProperty(ref _relaxationStats, value);
        }

        public string EntertainmentStats
        {
            get => _entertainmentStats;
            set => SetProperty(ref _entertainmentStats, value);
        }

        public string RestaurantsStats
        {
            get => _restaurantsStats;
            set => SetProperty(ref _restaurantsStats, value);
        }

        // Commands used by the home page buttons
        public ICommand NavigateToCategoryCommand { get; }
        public ICommand NavigateToRewardsCommand { get; }
        public ICommand NavigateToTartu101Command { get; }

        // Recalculates global progress and updates colors and texts
        public void RefreshProgress()
        {
            VisitedCount = _visitedService.GetVisitedCount();
            var percentage = TotalPlaces > 0 ? (int)((double)VisitedCount / TotalPlaces * 100) : 0;

            ProgressValue = percentage / 100.0;
            ProgressText = $"{percentage}%";
            VisitedText = $"{VisitedCount} / {TotalPlaces} places visited";

            // Golden style when all places are visited
            if (VisitedCount == TotalPlaces && TotalPlaces > 0)
            {
                ProgressBackgroundColor = Color.FromArgb("#fbbf24");
                ProgressColor = Color.FromArgb("#ffffff");
                ProgressTextColor = Color.FromArgb("#78350f");
            }
            else
            {
                // Default blue style
                ProgressBackgroundColor = Color.FromArgb("#eff6ff");
                ProgressColor = Color.FromArgb("#3b82f6");
                ProgressTextColor = Color.FromArgb("#1e3a8a");
            }

            // Update per-category statistics
            RefreshCategoryStats();
        }

        // Computes statistics for each category (History, Relaxation, etc.)
        private void RefreshCategoryStats()
        {
            var allPlaces = PlacesData.GetPlaces();
            var visitedPlaceIds = _visitedService.GetVisitedPlaces();

            HistoryStats = GetCategoryStats(allPlaces, visitedPlaceIds, "History");
            RelaxationStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Relaxation");
            EntertainmentStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Entertainment");
            RestaurantsStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Restaurants");
        }

        // Builds the "X/Y places visited" text for a given category
        private string GetCategoryStats(List<Models.Place> allPlaces, List<string> visitedPlaceIds, string category)
        {
            var categoryPlaces = allPlaces.Where(p => p.Category == category).ToList();
            var visitedInCategory = categoryPlaces.Count(p => visitedPlaceIds.Contains(p.Id));
            return $"{visitedInCategory}/{categoryPlaces.Count} places visited";
        }

        // Navigation helpers for the different sections of the app
        private async Task NavigateToCategory(string category)
        {
            await Shell.Current.GoToAsync($"CategoryListPage?category={category}");
        }

        private async Task NavigateToRewards()
        {
            await Shell.Current.GoToAsync("RewardsPage");
        }

        private async Task NavigateToTartu101()
        {
            await Shell.Current.GoToAsync("Tartu101Page");
        }
    }
}