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
                new Animal { Name = "Järvekonn", Image = "marshfrog.png", Description = "Järvekonn on konlaste sugukonda konna perekonda kuuluv kahepaikne. Järvekonn on levinud suures osas Euroopast, Venemaast ja Kesk-Aasiast. Järvekonn kuulub Eestis III kategooria kaitse alla. Järvekonn kuulub Euroopa Loodusdirektiivi alusel V kaitsekategooriasse."},
                new Animal { Name = "Tähnikvesilik", Image = "smoothnewt.png", Description = "Tähnikvesilik on salamanderlaste sugukonda kuuluv kahepaikne. Tähnikvesilik on levinud peaaegu kõikjal Euroopas. Eestis on tähnikvesilik väga tavaline. Elab järves. Isendite seljapiirkond on oliivpruuni värvi, kõhualune kollakas, keha kaetud tumedate täppidega."},
                new Animal { Name = "Harilik kärnkonn", Image = "commontoad.png", Description = "Harilik kärnkonn on kärnkonlaste sugukonda kuuluv konn. Harilikku kärnkonna leidub enamasti kogu Euroopas. Päevase aja veedavad kärnkonnad tavaliselt peidus lesides, seega on tegemist üsna silmatorkamatu liigiga. Harilik kärnkonn on Eestis III kategooria looduskaitse all."},
                new Animal { Name = "Rohukonn", Image = "grassfrog.png", Description = "Rohukonna leidub kogu Euroopas, kaasa arvatud Eestis. Eestis on ta mandril arvukas, saartel vähearvukas. Rohukonnad on pruunid ja kirju kõhualusega. Kuna ta ei ole kiire ja tal puuduvad röövloomade vastu head kaitsevahendid, on tema peamine kaitse varjevärvus. Rohukonn on Eestis III kategooria looduskaitse all olev liik."},
                new Animal { Name = "Harilik mudakonn", Image = "commonspadefoot.png", Description = "Harilik mudakonn ehk mudakonn on mudakonlaste sugukonda kuuluv kahepaikne. Täiskasvanud mudakonn on kuni 8 cm pikkune. Keha on ümar ja sile. Seljapool on kollakaspruun või helehall pruunide laikude ja täppidega ning mustade tähnidega, mille keskel on punane täpp. Mudakonn kuulub looduskaitsealuste liikide II kategooriasse."},
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