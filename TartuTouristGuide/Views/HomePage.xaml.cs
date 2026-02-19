using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    // Code-behind for HomePage.xaml
    public partial class HomePage : ContentPage
    {
        private readonly HomeViewModel _viewModel;

        // Sets up the ViewModel and data bindings
        public HomePage(HomeViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        // Updates progress stats and category counts when page appears
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.RefreshProgress();
        }
    }
}