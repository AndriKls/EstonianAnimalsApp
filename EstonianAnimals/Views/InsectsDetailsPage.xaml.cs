using EstonianAnimals.Models;
namespace EstonianAnimals.Views


{
    public partial class InsectsDetailsPage : ContentPage
    {
        public InsectsDetailsPage(Animal selectedInsect)
        {
            InitializeComponent();
            BindingContext = selectedInsect;
        }
    }
}
