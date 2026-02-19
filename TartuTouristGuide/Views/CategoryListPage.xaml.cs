using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    // Code-behind for CategoryListPage.xaml
    public partial class CategoryListPage : ContentPage
    {
        private readonly CategoryListViewModel _viewModel;

        // Sets up the ViewModel and bindings
        public CategoryListPage(CategoryListViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        // Refreshes the place list when the page appears (updates visited badges)
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.RefreshPlaces();
        }
    }
}
