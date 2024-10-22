using EstonianAnimals.Models;
namespace EstonianAnimals.Views


{

    public partial class AmphibiansDetailsPage : ContentPage
    {
        public AmphibiansDetailsPage(Animal selectedAmphibian)
        {
            InitializeComponent();
            BindingContext = selectedAmphibian;
        }
    }
}