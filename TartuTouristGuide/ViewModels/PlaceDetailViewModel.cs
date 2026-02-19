using System.Windows.Input;
using Microsoft.Maui.Controls;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    // ViewModel for displaying details of a single place and handling visited toggle
    public class PlaceDetailViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly VisitedPlacesService _visitedService;
        private string _placeId = string.Empty;
        private Place? _place;
        private bool _isVisited;
        private string _visitedText = string.Empty;
        private Color _checkboxColor = Color.FromArgb("#3b82f6");

        // Initializes commands for toggle, maps, and navigation
        public PlaceDetailViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;

            ToggleVisitedCommand = new Command(ToggleVisited);
            OpenMapsCommand = new Command(async () => await OpenMaps());
            BackCommand = new Command(async () => await GoBack());
        }

        public Place? Place
        {
            get => _place;
            set => SetProperty(ref _place, value);
        }

        public bool IsVisited
        {
            get => _isVisited;
            set
            {
                if (SetProperty(ref _isVisited, value))
                {
                    UpdateVisitedText();
                }
            }
        }

        public string VisitedText
        {
            get => _visitedText;
            set => SetProperty(ref _visitedText, value);
        }

        public Color CheckboxColor
        {
            get => _checkboxColor;
            set => SetProperty(ref _checkboxColor, value);
        }

        // Commands used by the place detail page
        public ICommand ToggleVisitedCommand { get; }
        public ICommand OpenMapsCommand { get; }
        public ICommand BackCommand { get; }

        // Loads place data from navigation query parameter
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("id"))
            {
                _placeId = Uri.UnescapeDataString(query["id"].ToString() ?? string.Empty);
                LoadPlace();
            }
        }

        // Loads the specific place and its visited status
        private void LoadPlace()
        {
            var allPlaces = PlacesData.GetPlaces();
            Place = allPlaces.FirstOrDefault(b => b.Id == _placeId);

            if (Place != null)
            {
                _isVisited = _visitedService.IsVisited(_placeId);
                OnPropertyChanged(nameof(IsVisited));
                UpdateVisitedText();
            }
        }

        // Toggles visited status and checks for new rewards if unlocked
        private async void ToggleVisited()
        {
            bool wasVisited = _isVisited;
            _visitedService.ToggleVisited(_placeId);

            _isVisited = _visitedService.IsVisited(_placeId);
            OnPropertyChanged(nameof(IsVisited));
            UpdateVisitedText();

            if (!wasVisited && _isVisited)
            {
                await CheckForNewRewards();
            }
        }

        // Updates button text and checkbox color based on visited status
        private void UpdateVisitedText()
        {
            VisitedText = _isVisited ? "Place visited" : "Mark as VISITED";
            CheckboxColor = _isVisited ? Color.FromArgb("#22c55e") : Color.FromArgb("#3b82f6");
        }

        // Checks if toggling this place unlocked any new rewards
        private async Task CheckForNewRewards()
        {
            try
            {
                var rewards = RewardsData.GetRewards();
                var visitedPlaces = _visitedService.GetVisitedPlaces();
                var visitedBeforeClick = visitedPlaces.Where(id => id != _placeId).ToList();

                foreach (var reward in rewards)
                {
                    bool wasUnlockedBefore = reward.RequiredPlaceIds.All(id => visitedBeforeClick.Contains(id));
                    bool isUnlockedNow = reward.RequiredPlaceIds.All(id => visitedPlaces.Contains(id));

                    if (!wasUnlockedBefore && isUnlockedNow)
                    {
                        await ShowRewardUnlockedPopup(reward);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error checking rewards: {ex.Message}");
            }
        }

        // Shows popup when a new reward is unlocked
        private async Task ShowRewardUnlockedPopup(Reward reward)
        {
            try
            {
                bool goToRewards = await Application.Current.MainPage.DisplayAlert(
                    "🏆 Reward Unlocked!",
                    $"{reward.Name}\n\n{reward.Description}",
                    "View Rewards",
                    "Continue Exploring"
                );

                if (goToRewards)
                {
                    await Shell.Current.GoToAsync("RewardsPage");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error showing popup: {ex.Message}");
            }
        }

        // Opens Google Maps with the place's address
        private async Task OpenMaps()
        {
            if (Place != null)
            {
                try
                {
                    var url = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(Place.Address)}";
                    await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
                }
                catch
                {
                    // Handle error silently or show a message
                }
            }
        }

        // Navigates back to previous page
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("../..");
        }
    }
}