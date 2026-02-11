using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    public partial class RewardsPage : ContentPage
    {
        private readonly RewardsViewModel _viewModel;

        public RewardsPage(RewardsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadRewards();
        }
    }
}