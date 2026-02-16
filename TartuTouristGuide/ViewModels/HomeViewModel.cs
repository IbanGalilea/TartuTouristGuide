using System.Collections.ObjectModel;
using System.Windows.Input;
using TartuTouristGuide.Data;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
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

        // Nouvelles propriétés pour les statistiques par catégorie
        private string _historyStats = string.Empty;
        private string _relaxationStats = string.Empty;
        private string _entertainmentStats = string.Empty;
        private string _restaurantsStats = string.Empty;

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

        public ICommand NavigateToCategoryCommand { get; }
        public ICommand NavigateToRewardsCommand { get; }
        public ICommand NavigateToTartu101Command { get; }

        public void RefreshProgress()
        {
            VisitedCount = _visitedService.GetVisitedCount();
            var percentage = TotalPlaces > 0 ? (int)((double)VisitedCount / TotalPlaces * 100) : 0;

            ProgressValue = percentage / 100.0;
            ProgressText = $"{percentage}%";
            VisitedText = $"{VisitedCount} / {TotalPlaces} places visited";

            // Style doré si tout est visité (100%)
            if (VisitedCount == TotalPlaces && TotalPlaces > 0)
            {
                // Fond doré avec dégradé
                ProgressBackgroundColor = Color.FromArgb("#fbbf24"); // Fond doré
                ProgressColor = Color.FromArgb("#ffffff"); // Barre blanche
                ProgressTextColor = Color.FromArgb("#78350f"); // Texte marron foncé
            }
            else
            {
                // Style normal bleu
                ProgressBackgroundColor = Color.FromArgb("#eff6ff"); // Fond bleu clair
                ProgressColor = Color.FromArgb("#3b82f6"); // Barre bleue
                ProgressTextColor = Color.FromArgb("#1e3a8a"); // Texte bleu foncé
            }

            // Calculer les statistiques par catégorie
            RefreshCategoryStats();
        }

        private void RefreshCategoryStats()
        {
            var allPlaces = PlacesData.GetPlaces();
            var visitedPlaceIds = _visitedService.GetVisitedPlaces();

            HistoryStats = GetCategoryStats(allPlaces, visitedPlaceIds, "History");
            RelaxationStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Relaxation");
            EntertainmentStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Entertainment");
            RestaurantsStats = GetCategoryStats(allPlaces, visitedPlaceIds, "Restaurants");
        }

        private string GetCategoryStats(List<Models.Place> allPlaces, List<string> visitedPlaceIds, string category)
        {
            var categoryPlaces = allPlaces.Where(p => p.Category == category).ToList();
            var visitedInCategory = categoryPlaces.Count(p => visitedPlaceIds.Contains(p.Id));
            return $"{visitedInCategory}/{categoryPlaces.Count} places visited";
        }

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
