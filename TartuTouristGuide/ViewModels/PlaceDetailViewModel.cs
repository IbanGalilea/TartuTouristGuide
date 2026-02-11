using System.Windows.Input;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    public class PlaceDetailViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly VisitedPlacesService _visitedService;
        private string _PlaceId = string.Empty;
        private Place? _Place;
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
            get => _Place;
            set => SetProperty(ref _Place, value);
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
                _PlaceId = Uri.UnescapeDataString(query["id"].ToString() ?? string.Empty);
                LoadPlace();
            }
        }

        private void LoadPlace()
        {
            var allPlaces = PlacesData.GetPlaces();
            Place = allPlaces.FirstOrDefault(b => b.Id == _PlaceId);

            if (Place != null)
            {
                IsVisited = _visitedService.IsVisited(_PlaceId);
            }
        }

        private void ToggleVisited()
        {
            _visitedService.ToggleVisited(_PlaceId);
            IsVisited = _visitedService.IsVisited(_PlaceId);
        }

        private void UpdateVisitedText()
        {
            VisitedText = IsVisited ? "Place visited" : "Mark as VISITED";
            CheckboxColor = IsVisited ? Color.FromArgb("#22c55e") : Color.FromArgb("#3b82f6");
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