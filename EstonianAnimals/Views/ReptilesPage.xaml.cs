using System.Collections.ObjectModel;
using EstonianAnimals.Models;

namespace EstonianAnimals.Views
{
    public partial class ReptilesPage : ContentPage
    {
        public ObservableCollection<Animal> Reptiles { get; set; }

        public ReptilesPage()
        {
            InitializeComponent();

            Reptiles = new ObservableCollection<Animal>
            {
                new Animal { Name = "Rästik", Image = "", Description = "" },
                new Animal { Name = "Nastik", Image = "", Description = "" },
                new Animal { Name = "Vaskuss", Image = "", Description = "" },
                new Animal { Name = "Kivisisalik", Image = "", Description = "" },
                new Animal { Name = "Arusisalik", Image = "", Description = "" },
            };

            BindingContext = this;
        }

        async void OnReptileSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedReptile)
            {
                await Navigation.PushAsync(new ReptileDetailsPage(selectedReptile));
            }
        }
    }
}
