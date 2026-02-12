using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    public class CategoryListViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly VisitedPlacesService _visitedService;
        private string _category = string.Empty;
        private string _countText = string.Empty;
        private ObservableCollection<Place> _buildings = new();

        public CategoryListViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;
            NavigateToPlaceCommand = new Command<string>(async (buildingId) => await NavigateToPlace(buildingId));
        }

        public string Category
        {
            get => _category;
            set
            {
                if (SetProperty(ref _category, value))
                {
                    LoadPlaces();
                }
            }
        }

        public string CountText
        {
            get => _countText;
            set => SetProperty(ref _countText, value);
        }

        public ObservableCollection<Place> Places
        {
            get => _buildings;
            set => SetProperty(ref _buildings, value);
        }

        public ICommand NavigateToPlaceCommand { get; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("category"))
            {
                Category = Uri.UnescapeDataString(query["category"].ToString() ?? string.Empty);
            }
        }

        private void LoadPlaces()
        {
            var allPlaces = PlacesData.GetPlaces();
            var categoryPlaces = allPlaces.Where(b => b.Category == Category).ToList();

            Places = new ObservableCollection<Place>(categoryPlaces);
            CountText = $"{categoryPlaces.Count} {(categoryPlaces.Count > 1 ? "places" : "place")} to discover";
        }

        private async Task NavigateToPlace(string buildingId)
        {
            await Shell.Current.GoToAsync($"PlaceDetailPage?id={buildingId}");
        }
    }
}