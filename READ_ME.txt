================================================================================
TARTU TOURIST GUIDE - .NET MAUI APP
================================================================================

OVERVIEW
--------
Mobile app for tourists visiting Tartu, Estonia. Users discover places organized 
by category, mark places as visited, unlock rewards, and access practical info.

MAIN FEATURES:
- Browse places by category (History, Relaxation, Entertainment, Food)
- Mark places as visited (persists between app sessions)
- Progress tracking with golden celebration at 100%
- Reward system (unlock achievements by visiting specific places)
- "Tartu 101" practical guide (emergencies, transport, supermarkets, etc)
- Google Maps integration
- Clean, modern UI with category-colored cards

TECHNICAL STACK
---------------
- .NET MAUI (cross-platform: iOS/Android/Windows)
- MVVM pattern with data binding
- Dependency Injection (Microsoft.Extensions)
- Local storage via Preferences API
- Shell navigation

================================================================================
DEPENDENCY INJECTION SETUP (MauiProgram.cs)
================================================================================

SINGLETON (shared across entire app):
- VisitedPlacesService → Stores visited place IDs (persists via Preferences)

TRANSIENT (fresh instance each time):
- All ViewModels (HomeViewModel, CategoryListViewModel, etc)
- All Pages (HomePage, CategoryListPage, etc)

Why? Singleton for shared app state, Transient for fresh data on each navigation.

================================================================================
FILE STRUCTURE
================================================================================

📁 Services/
├── VisitedPlacesService.cs
│   └── Manages visited places (load/save/check/toggle from Preferences)

📁 ViewModels/
├── BaseViewModel.cs
│   └── MVVM base class (INotifyPropertyChanged + SetProperty helper)
├── HomeViewModel.cs
│   └── Home screen: category stats, global progress bar, navigation commands
├── CategoryListViewModel.cs
│   └── Category page: filtered place list with visited count
├── PlaceDetailViewModel.cs
│   └── Single place details: toggle visited + rewards popup + maps
├── RewardsViewModel.cs
│   └── Rewards page: shows locked/unlocked rewards with progress
└── PlaceItem.cs, RewardItem.cs
    └── Display wrappers (Place + IsVisited, Reward + unlock status)

📁 Views/
├── HomePage.xaml + .cs
│   └── Category buttons + progress bar + rewards button
├── CategoryListPage.xaml + .cs
│   └── Scrollable place cards (tap → details, toolbar reset button)
├── PlaceDetailPage.xaml + .cs
│   └── Hero image + details + visited toggle checkbox + maps
├── RewardsPage.xaml + .cs
│   └── Reward cards (dimmed if locked) + encouragement/completion messages
├── Tartu101Page.xaml + .cs
│   └── Static practical info (emergencies, transport, supermarkets, etc)
└── *.xaml.cs (all pages)
    └── Simple code-behind: set BindingContext + OnAppearing refresh

📁 Data/
├── PlacesData.cs 
│   └── Static list of all places (Id, Name, Category, Image, etc)
└── RewardsData.cs
    └── Static list of rewards (Name, RequiredPlaceIds, Image, etc)

📁 Models/
├── Place.cs
│   └── Place data (Id, Name, Category, Image, Address, Hours, etc)
└── Reward.cs
    └── Reward data (Name, Category, RequiredPlaceIds, Image, Description)

================================================================================
KEY CONCEPTS FOR INTERNS
================================================================================

1. MVVM PATTERN
   - ViewModels expose data/commands → XAML binds automatically
   - BaseViewModel handles property change notifications
   - SetProperty() checks equality before updating (performance + avoids loops)

2. VISITED STATE LOGIC
   - HashSet<string> stores place IDs in Preferences as comma-separated string
   - ToggleVisited() → add/remove → auto-save
   - Load on app start, save on every toggle

3. NAVIGATION
   - Shell.Current.GoToAsync("CategoryListPage?category=History")
   - IQueryAttributable extracts query params (id, category)
   - "../.." or ".." for back navigation

4. UI PATTERNS
   - Hero images with dark overlay + white text (all place/reward cards)
   - Category-colored buttons (History=Blue, Food=Orange, etc)
   - Progress bar turns golden at 100%
   - Shadows on all cards (professional polish)

5. REWARDS SYSTEM
   - Each reward requires specific place IDs
   - PlaceDetail checks on toggle: "was locked before → unlocked now?" → popup
   - Rewards page shows lock overlay (opacity 0.3) for locked rewards

6. PERFORMANCE
   - CollectionView with RemainingItemsThreshold + ItemSizingStrategy
   - Virtualisation prevents lag with many places

================================================================================
STYLING COLORS (category buttons)
================================================================================
Tartu 101:    #ef4444 (red)
History:      #3b82f6 (blue)  
Relaxation:   #22c55e (green)
Entertainment:#a855f7 (purple)
Food:         #f97316 (orange)

GOLDEN PROGRESS (100%): #fbbf24 background + white bar

================================================================================
NEXT FEATURES (easy additions)
================================================================================
[ ] Search bar in categories
[ ] Filter by visited/unvisited  
[ ] Share progress on social media
[ ] Offline maps
[ ] Push notifications for nearby places
[ ] Estonian language support

Happy coding! 🏛️✨

Last updated: Feb 2026
