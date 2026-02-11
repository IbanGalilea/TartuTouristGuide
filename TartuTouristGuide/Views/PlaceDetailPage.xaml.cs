using TartuTouristGuide.ViewModels;

namespace TartuTouristGuide.Views
{
    public partial class PlaceDetailPage : ContentPage
    {
        private readonly PlaceDetailViewModel _viewModel;

        public PlaceDetailPage(PlaceDetailViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        private void OnCheckBoxChanged(object sender, CheckedChangedEventArgs e)
        {
            // Le binding IsChecked met déjà à jour le ViewModel
            // Mais on doit appeler ToggleVisitedCommand pour sauvegarder
            if (_viewModel.ToggleVisitedCommand.CanExecute(null))
            {
                _viewModel.ToggleVisitedCommand.Execute(null);
            }
        }
    }
}