using EstonianAnimals.Views;

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
            await Navigation.PushAsync(new MammalsPage());
        }

        private async void OnBirdsButtonClicked(object sender, EventArgs e)
        {
            
        }

        private async void OnFishButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FishPage());   
        }

        private async void OnReptilesButtonClicked(object sender, EventArgs e)
        {
            
        }

        private async void OnAmphibiansButtonClicked(object sender, EventArgs e)
        {
            
        }

        private async void OnInsectsButtonClicked(object sender, EventArgs e)
        {
            
        }

        
    }
}
