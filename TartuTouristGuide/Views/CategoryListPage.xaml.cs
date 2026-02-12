using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    public partial class CategoryListPage : ContentPage
    {
        private readonly CategoryListViewModel _viewModel;

        public CategoryListPage(CategoryListViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Rafraîchir la liste pour mettre à jour les badges "Visited"
            _viewModel.RefreshPlaces();
        }
    }
}
