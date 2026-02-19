using System.Collections.ObjectModel;
using TartuTouristGuide.Data;
using TartuTouristGuide.Models;
using TartuTouristGuide.Services;

namespace TartuTouristGuide.ViewModels
{
    // Represents a reward and its unlock status for display
    public class RewardItem
    {
        public Reward Reward { get; set; } = new Reward();
        public bool IsUnlocked { get; set; }
        public string DisplayText { get; set; } = string.Empty;
        public double OverlayOpacity { get; set; }
    }

    // ViewModel for the rewards page: shows unlock status of all rewards
    public class RewardsViewModel : BaseViewModel
    {
        private readonly VisitedPlacesService _visitedService;
        private ObservableCollection<RewardItem> _rewardItems = new();
        private string _unlockedText = string.Empty;
        private bool _showEncouragement;
        private bool _showCompletion;

        public RewardsViewModel(VisitedPlacesService visitedService)
        {
            _visitedService = visitedService;
        }

        public ObservableCollection<RewardItem> RewardItems
        {
            get => _rewardItems;
            set => SetProperty(ref _rewardItems, value);
        }

        public string UnlockedText
        {
            get => _unlockedText;
            set => SetProperty(ref _unlockedText, value);
        }

        public bool ShowEncouragement
        {
            get => _showEncouragement;
            set => SetProperty(ref _showEncouragement, value);
        }

        public bool ShowCompletion
        {
            get => _showCompletion;
            set => SetProperty(ref _showCompletion, value);
        }

        // Loads all rewards and calculates their unlock status
        public void LoadRewards()
        {
            var rewards = RewardsData.GetRewards();
            var visitedPlaces = _visitedService.GetVisitedPlaces();

            var items = new ObservableCollection<RewardItem>();
            int unlockedCount = 0;

            foreach (var reward in rewards)
            {
                bool isUnlocked = reward.RequiredPlaceIds.All(id => visitedPlaces.Contains(id));
                if (isUnlocked) unlockedCount++;

                if (reward.Category != "Final")
                {
                    items.Add(new RewardItem
                    {
                        Reward = reward,
                        IsUnlocked = isUnlocked,
                        DisplayText = isUnlocked ? reward.Description : $"🔒 Visit all {reward.RequiredPlaceIds.Count} places in the {reward.Category} category to unlock",
                        OverlayOpacity = isUnlocked ? 0.85 : 0.3
                    });
                }
                else
                {
                    items.Add(new RewardItem
                    {
                        Reward = reward,
                        IsUnlocked = isUnlocked,
                        DisplayText = isUnlocked ? reward.Description : $"🔒 Visit every places in Tartu to unlock ({visitedPlaces.Count}/{PlacesData.GetPlaces().Count})",
                        OverlayOpacity = isUnlocked ? 0.85 : 0.3
                    });
                }
            }

            RewardItems = items;
            UnlockedText = $"{unlockedCount} / {rewards.Count} rewards unlocked";
            ShowEncouragement = unlockedCount < rewards.Count;
            ShowCompletion = unlockedCount == rewards.Count;
        }
    }
}