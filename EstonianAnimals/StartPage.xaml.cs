using EstonianAnimals;

namespace MauiApp1.Views
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        async void ExploreNow_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }
    }
}