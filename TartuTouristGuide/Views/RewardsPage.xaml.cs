using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    // Code-behind for RewardsPage.xaml
    public partial class RewardsPage : ContentPage
    {
        private readonly RewardsViewModel _viewModel;

        // Sets up the ViewModel and data bindings
        public RewardsPage(RewardsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        // Loads current rewards status when page appears
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadRewards();
        }
    }
}