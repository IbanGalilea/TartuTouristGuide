using TartuTouristGuide.Views;

namespace TartuTouristGuide
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("CategoryListPage", typeof(CategoryListPage));
            Routing.RegisterRoute("PlaceDetailPage", typeof(PlaceDetailPage));
            Routing.RegisterRoute("RewardsPage", typeof(RewardsPage));
        }
    }
}