using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    // Code-behind for PlaceDetailPage.xaml
    public partial class PlaceDetailPage : ContentPage
    {
        // Simple constructor: sets up ViewModel binding
        public PlaceDetailPage(PlaceDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}