using EstonianAnimals.Models;
namespace EstonianAnimals.Views


{

    public partial class BirdsDetailsPage : ContentPage
    {
        public BirdsDetailsPage(Animal selectedBird)
        {
            InitializeComponent();
            BindingContext = selectedBird;
        }
    }
}