using TartuTouristGuide.Views;

namespace TartuTouristGuide
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;

            Routing.RegisterRoute("CategoryListPage", typeof(CategoryListPage));
            Routing.RegisterRoute("PlaceDetailPage", typeof(PlaceDetailPage));
            Routing.RegisterRoute("RewardsPage", typeof(RewardsPage));
            Routing.RegisterRoute("Tartu101Page", typeof(Tartu101Page));
        }
    }
}