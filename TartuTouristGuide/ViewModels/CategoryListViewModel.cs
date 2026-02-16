using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    public class PlaceItem
    {
        public Place Place { get; set; } = new Place();
        public bool IsVisited { get; set; }
    }

    public class CategoryListViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly VisitedPlacesService _visitedService;
        private string _category = string.Empty;
        private string _countText = string.Empty;
        private ObservableCollection<PlaceItem> _placeItems = new();

        public CategoryListViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;
            NavigateToPlaceCommand = new Command<string>(async (placeId) => await NavigateToPlace(placeId));
            ResetCategoryCommand = new Command(async () => await ResetCategory());
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

        public ObservableCollection<PlaceItem> PlaceItems
        {
            get => _placeItems;
            set => SetProperty(ref _placeItems, value);
        }

        public ICommand NavigateToPlaceCommand { get; }
        public ICommand ResetCategoryCommand { get; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("category"))
            {
                Category = Uri.UnescapeDataString(query["category"].ToString() ?? string.Empty);
            }
        }

        public void RefreshPlaces()
        {
            LoadPlaces();
        }

        private void LoadPlaces()
        {
            var allPlaces = PlacesData.GetPlaces();
            var categoryPlaces = allPlaces.Where(b => b.Category == Category).ToList();
            var visitedPlaces = _visitedService.GetVisitedPlaces();
            var visitedInCategory = categoryPlaces.Count(p => visitedPlaces.Contains(p.Id));

            var items = new ObservableCollection<PlaceItem>();
            foreach (var place in categoryPlaces)
            {
                items.Add(new PlaceItem
                {
                    Place = place,
                    IsVisited = visitedPlaces.Contains(place.Id)
                });
            }

            PlaceItems = items;
            CountText = $"{visitedInCategory}/{categoryPlaces.Count} {(categoryPlaces.Count > 1 ? "places" : "place")} discovered";
        }

        private async Task ResetCategory()
        {
            bool confirm = await Application.Current.MainPage.DisplayAlert(
                "Reset Category",
                $"Are you sure you want to mark all places in {Category} as not visited?",
                "Yes, Reset",
                "Cancel"
            );

            if (confirm)
            {
                var allPlaces = PlacesData.GetPlaces();
                var categoryPlaces = allPlaces.Where(b => b.Category == Category).ToList();

                foreach (var place in categoryPlaces)
                {
                    if (_visitedService.IsVisited(place.Id))
                    {
                        _visitedService.ToggleVisited(place.Id);
                    }
                }

                // Rafraîchir la liste
                LoadPlaces();

                await Application.Current.MainPage.DisplayAlert(
                    "Reset Complete",
                    $"All places in {Category} have been reset.",
                    "OK"
                );
            }
        }

        private async Task NavigateToPlace(string placeId)
        {
            await Shell.Current.GoToAsync($"PlaceDetailPage?id={placeId}");
        }
    }
}
