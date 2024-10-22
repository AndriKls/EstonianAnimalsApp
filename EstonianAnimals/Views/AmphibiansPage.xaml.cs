using System.Collections.ObjectModel;
using EstonianAnimals.Models;


namespace EstonianAnimals.Views
{
    public partial class AmphibiansPage : ContentPage
    {
        public ObservableCollection<Animal> Amphibians { get; set; }

        public AmphibiansPage()
        {
            InitializeComponent();

            Amphibians = new ObservableCollection<Animal>
            {
                new Animal { Name = "Järvekonn", Image = "", Description = ""},
            };

            BindingContext = this;
        }

        async void OnAmphibianSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedAmphibian)
            {
                await Navigation.PushAsync(new AmphibiansDetailsPage(selectedAmphibian));
            }
        }
    }
}