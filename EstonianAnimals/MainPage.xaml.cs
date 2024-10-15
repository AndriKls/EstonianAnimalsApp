namespace EstonianAnimals
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMammalsButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Imetajad", "Sa valisid imetajad.", "OK");
        }

        private async void OnBirdsButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Linnud", "Sa valisid linnud.", "OK");
        }

        private async void OnFishButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kalad", "Sa valisid kalad.", "OK");
        }

        private async void OnReptilesButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Roomajad", "Sa valisid roomajad.", "OK");
        }

        private async void OnAmphibiansButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kahepaiksed", "Sa valisid kahepaiksed.", "OK");
        }

        private async void OnInsectsButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Putukad", "Sa valisid putukad.", "OK");
        }

        private async void OnInvertebratesButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Selgrootud", "Sa valisid selgrootud.", "OK");
        }
    }
}
