using System.Windows.Input;
using Microsoft.Maui.Controls;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    public class PlaceDetailViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly VisitedPlacesService _visitedService;
        private string _placeId = string.Empty;
        private Place? _place;
        private bool _isVisited;
        private string _visitedText = string.Empty;
        private Color _checkboxColor = Color.FromArgb("#3b82f6");

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

        public ICommand ToggleVisitedCommand { get; }
        public ICommand OpenMapsCommand { get; }
        public ICommand BackCommand { get; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("id"))
            {
                _placeId = Uri.UnescapeDataString(query["id"].ToString() ?? string.Empty);
                LoadPlace();
            }
        }

        private void LoadPlace()
        {
            var allPlaces = PlacesData.GetPlaces();
            Place = allPlaces.FirstOrDefault(b => b.Id == _placeId);

            if (Place != null)
            {
                _isVisited = _visitedService.IsVisited(_placeId);
                OnPropertyChanged(nameof(IsVisited));
                UpdateVisitedText(); // Initialiser le texte dès le début
            }
        }

        private void ToggleVisited()
        {
            _visitedService.ToggleVisited(_placeId);

            // Mettre à jour l'état
            _isVisited = _visitedService.IsVisited(_placeId);
            OnPropertyChanged(nameof(IsVisited));
            UpdateVisitedText();

            // Vérifier les nouveaux succès débloqués
            CheckForNewRewards();
        }

        private void UpdateVisitedText()
        {
            VisitedText = _isVisited ? "Place visited" : "Mark as VISITED";
            CheckboxColor = _isVisited ? Color.FromArgb("#22c55e") : Color.FromArgb("#3b82f6");
        }

        private async void CheckForNewRewards()
        {
            var rewards = RewardsData.GetRewards();
            var visitedPlaces = _visitedService.GetVisitedPlaces();

            foreach (var reward in rewards)
            {
                bool wasUnlockedBefore = reward.RequiredPlaceIds
                    .Where(id => id != _placeId)
                    .All(id => visitedPlaces.Contains(id));

                bool isUnlockedNow = reward.RequiredPlaceIds
                    .All(id => visitedPlaces.Contains(id));

                // Si le succès vient d'être débloqué
                if (!wasUnlockedBefore && isUnlockedNow)
                {
                    await ShowRewardUnlockedPopup(reward);
                }
            }
        }

        private async Task ShowRewardUnlockedPopup(Reward reward)
        {
            bool goToRewards = await Application.Current.MainPage.DisplayAlert(
                "🏆 Reward Unlocked!",
                $"{reward.Name}\n\n{reward.Description}",
                "View Rewards",
                "Continue Exploring"
            );

            if (goToRewards)
            {
                await Shell.Current.GoToAsync("//HomePage/RewardsPage");
            }
        }

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

        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
