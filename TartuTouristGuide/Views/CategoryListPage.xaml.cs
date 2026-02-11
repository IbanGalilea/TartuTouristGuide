using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    public partial class CategoryListPage : ContentPage
    {
        public CategoryListPage(CategoryListViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}