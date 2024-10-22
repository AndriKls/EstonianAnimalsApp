using System.Collections.ObjectModel;
using EstonianAnimals.Models;


namespace EstonianAnimals.Views
{
    public partial class BirdsPage : ContentPage
    {
        public ObservableCollection<Animal> Birds { get; set; }

        public BirdsPage()
        {
            InitializeComponent();

            Birds = new ObservableCollection<Animal>
            {
                new Animal { Name = "Rasvatihane", Image = "", Description = "" },
            };

            BindingContext = this;
        }

        async void OnBirdSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedBird)
            {
                await Navigation.PushAsync(new BirdsDetailsPage(selectedBird));
            }
        }
    }
}
