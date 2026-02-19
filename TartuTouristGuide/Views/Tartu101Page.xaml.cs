namespace TartuTouristGuide.Views
{
    // Code-behind for Tartu101Page.xaml (static content page)
    public partial class Tartu101Page : ContentPage
    {
        public Tartu101Page()
        {
            InitializeComponent();
        }

        // Opens Tartu tourist website when the link is tapped
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

        // Navigates back to home page
        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}