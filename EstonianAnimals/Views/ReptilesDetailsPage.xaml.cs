using EstonianAnimals.Models;

namespace EstonianAnimals.Views
{
    public partial class ReptileDetailsPage : ContentPage
    {
        public ReptileDetailsPage(Animal selectedReptile)
        {
            InitializeComponent();
            BindingContext = selectedReptile;
        }
    }
}
