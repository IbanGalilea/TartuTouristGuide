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

        public HomeViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;
            _totalPlaces = PlacesData.GetPlaces().Count;

            NavigateToCategoryCommand = new Command<string>(async (category) => await NavigateToCategory(category));
            NavigateToRewardsCommand = new Command(async () => await NavigateToRewards());

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

        public ICommand NavigateToCategoryCommand { get; }
        public ICommand NavigateToRewardsCommand { get; }

        public void RefreshProgress()
        {
            VisitedCount = _visitedService.GetVisitedCount();
            var percentage = TotalPlaces > 0 ? (int)((double)VisitedCount / TotalPlaces * 100) : 0;

            ProgressValue = percentage / 100.0;
            ProgressText = $"{percentage}%";
            VisitedText = $"{VisitedCount} / {TotalPlaces} places visited";
        }

        private async Task NavigateToCategory(string category)
        {
            await Shell.Current.GoToAsync($"CategoryListPage?category={category}");
        }

        private async Task NavigateToRewards()
        {
            await Shell.Current.GoToAsync("RewardsPage");
        }
    }
}