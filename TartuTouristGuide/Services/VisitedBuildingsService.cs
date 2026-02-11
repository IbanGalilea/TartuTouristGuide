using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var visited = Preferences.Get(VisitedKey, "");
            _visitedPlaces = string.IsNullOrEmpty(visited)
                ? new HashSet<string>()
                : new HashSet<string>(visited.Split(','));
        }

        private void SaveVisitedPlaces()
        {
            Preferences.Set(VisitedKey, string.Join(",", _visitedPlaces));
        }

        public bool IsVisited(string PlaceId)
        {
            return _visitedPlaces.Contains(PlaceId);
        }

        public void ToggleVisited(string PlaceId)
        {
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
            return _visitedPlaces.ToList();
        }
    }
}