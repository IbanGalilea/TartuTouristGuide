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
        private const string VisitedKey = "visited_Places";
        private HashSet<string> _visitedPlaces = new HashSet<string>();

        public VisitedPlacesService()
        {
            LoadVisitedPlaces();
        }

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
                // Si Preferences lève une exception, on initialise proprement la collection
                _visitedPlaces = new HashSet<string>();
            }
        }

        private void SaveVisitedPlaces()
        {
            try
            {
                Preferences.Set(VisitedKey, string.Join(",", _visitedPlaces));
            }
            catch
            {
                // Échec d'enregistrement : on ignore pour éviter le plantage en runtime
            }
        }

        public bool IsVisited(string PlaceId)
        {
            if (string.IsNullOrWhiteSpace(PlaceId))
                return false;

            return _visitedPlaces.Contains(PlaceId);
        }

        public void ToggleVisited(string PlaceId)
        {
            if (string.IsNullOrWhiteSpace(PlaceId))
                return;

            if (_visitedPlaces.Contains(PlaceId))
            {
                _visitedPlaces.Remove(PlaceId);
            }
            else
            {
                _visitedPlaces.Add(PlaceId);
            }
            SaveVisitedPlaces();
        }

        public int GetVisitedCount()
        {
            return _visitedPlaces.Count;
        }

        public List<string> GetVisitedPlaces()
        {
            return _visitedPlaces.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        }
    }
}