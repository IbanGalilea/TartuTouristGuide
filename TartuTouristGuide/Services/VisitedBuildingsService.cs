using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;

namespace TartuTouristGuide.Services
{
    public class VisitedPlacesService
    {
        // Used to save and load the list of visited places from Preferences
        private const string VisitedKey = "visited_Places";

        // Stores all visited place IDs
        private HashSet<string> _visitedPlaces = new HashSet<string>();

        // Load saved places when the service is created
        public VisitedPlacesService()
        {
            LoadVisitedPlaces();
        }

        // Get the visited places list from local storage
        private void LoadVisitedPlaces()
        {
            try
            {
                var visited = Preferences.Get(VisitedKey, "");
                _visitedPlaces = string.IsNullOrWhiteSpace(visited)
                    ? new HashSet<string>()
                    : new HashSet<string>(visited
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim()));
            }
            catch
            {
                _visitedPlaces = new HashSet<string>();
            }
        }

        // Save the updated visited places list to local storage
        private void SaveVisitedPlaces()
        {
            try
            {
                Preferences.Set(VisitedKey, string.Join(",", _visitedPlaces));
            }
            catch
            {
            }
        }

        // Check if a specific place has been visited
        public bool IsVisited(string PlaceId)
        {
            if (string.IsNullOrWhiteSpace(PlaceId))
                return false;

            return _visitedPlaces.Contains(PlaceId);
        }

        // Add or remove a place from the visited list
        public void ToggleVisited(string PlaceId)
        {
            if (string.IsNullOrWhiteSpace(PlaceId))
                return;

            if (_visitedPlaces.Contains(PlaceId))
                _visitedPlaces.Remove(PlaceId);
            else
                _visitedPlaces.Add(PlaceId);

            SaveVisitedPlaces();
        }

        // Get total number of visited places
        public int GetVisitedCount()
        {
            return _visitedPlaces.Count;
        }

        // Get all visited place IDs
        public List<string> GetVisitedPlaces()
        {
            return _visitedPlaces.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        }
    }
}