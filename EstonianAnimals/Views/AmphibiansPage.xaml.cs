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
                new Animal { Name = "J�rvekonn", Image = "marshfrog.png", Description = "J�rvekonn on konlaste sugukonda konna perekonda kuuluv kahepaikne. J�rvekonn on levinud suures osas Euroopast, Venemaast ja Kesk-Aasiast. J�rvekonn kuulub Eestis III kategooria kaitse alla. J�rvekonn kuulub Euroopa Loodusdirektiivi alusel V kaitsekategooriasse."},
                new Animal { Name = "T�hnikvesilik", Image = "smoothnewt.png", Description = "T�hnikvesilik on salamanderlaste sugukonda kuuluv kahepaikne. T�hnikvesilik on levinud peaaegu k�ikjal Euroopas. Eestis on t�hnikvesilik v�ga tavaline. Elab j�rves. Isendite seljapiirkond on oliivpruuni v�rvi, k�hualune kollakas, keha kaetud tumedate t�ppidega."},
                new Animal { Name = "Harilik k�rnkonn", Image = "commontoad.png", Description = "Harilik k�rnkonn on k�rnkonlaste sugukonda kuuluv konn. Harilikku k�rnkonna leidub enamasti kogu Euroopas. P�evase aja veedavad k�rnkonnad tavaliselt peidus lesides, seega on tegemist �sna silmatorkamatu liigiga. Harilik k�rnkonn on Eestis III kategooria looduskaitse all."},
                new Animal { Name = "Rohukonn", Image = "grassfrog.png", Description = "Rohukonna leidub kogu Euroopas, kaasa arvatud Eestis. Eestis on ta mandril arvukas, saartel v�hearvukas. Rohukonnad on pruunid ja kirju k�hualusega. Kuna ta ei ole kiire ja tal puuduvad r��vloomade vastu head kaitsevahendid, on tema peamine kaitse varjev�rvus. Rohukonn on Eestis III kategooria looduskaitse all olev liik."},
                new Animal { Name = "Harilik mudakonn", Image = "commonspadefoot.png", Description = "Harilik mudakonn ehk mudakonn on mudakonlaste sugukonda kuuluv kahepaikne. T�iskasvanud mudakonn on kuni 8 cm pikkune. Keha on �mar ja sile. Seljapool on kollakaspruun v�i helehall pruunide laikude ja t�ppidega ning mustade t�hnidega, mille keskel on punane t�pp. Mudakonn kuulub looduskaitsealuste liikide II kategooriasse."},
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