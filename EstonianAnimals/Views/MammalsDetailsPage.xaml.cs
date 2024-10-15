using EstonianAnimals.Models;
namespace EstonianAnimals.Views


{
    public partial class MammalDetailsPage : ContentPage
    {
        public MammalDetailsPage(Animal selectedMammal)
        {
            InitializeComponent();
            BindingContext = selectedMammal;
        }
    }
}
