using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    public partial class PlaceDetailPage : ContentPage
    {
        public PlaceDetailPage(PlaceDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}