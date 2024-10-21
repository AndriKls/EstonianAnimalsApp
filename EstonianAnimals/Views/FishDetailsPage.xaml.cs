using EstonianAnimals.Models;

namespace EstonianAnimals.Views
{
    public partial class FishDetailsPage : ContentPage
    {
        public FishDetailsPage(Animal selectedFish)
        {
            InitializeComponent();
            BindingContext = selectedFish;
        }
    }
}
