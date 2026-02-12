namespace TartuTouristGuide.Views
{
    public partial class Tartu101Page : ContentPage
    {
        public Tartu101Page()
        {
            InitializeComponent();
        }

        private async void OnWebsiteTapped(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync("https://visittartu.com", BrowserLaunchMode.SystemPreferred);
            }
            catch
            {
                // Handle error silently
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
