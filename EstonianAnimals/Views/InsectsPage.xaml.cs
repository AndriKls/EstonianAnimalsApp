using System.Collections.ObjectModel;
using EstonianAnimals.Models;


namespace EstonianAnimals.Views
{
    public partial class InsectsPage : ContentPage
    {
        public ObservableCollection<Animal> Insects { get; set; }

        public InsectsPage()
        {
            InitializeComponent();

            Insects = new ObservableCollection<Animal>

            {
                new Animal { Name = "Rohutirts", Image = "grasshopper.png", Description = "Rohutirtsud elavad Eestis rohkete rohumaade ja metsade vahel. Rohutirtsud toituvad peamiselt rohust ja taimedest, olles samal ajal olulised looduslike tasakaalude säilitajad." },
                new Animal { Name = "Maakimalane", Image = "buff_tailed_bumblebee.png", Description = "Maakimalane on Eestis laialt levinud, eriti Lääne- ja Lõuna-Eestis, kus nad tolmeldavad kohalikke taimi ja õistaimi.\r\nMaakimalane on tuntud oma särava värvi ja unikaalse kehaehituse poolest, olles sageli märk keskkonna puhtusest. Nad elavad peamiselt metsades ja rohumaadel, kus nad saavad toitu otsida ja peidus olla. Maakimalased toituvad peamiselt õitest ja lehtedest, olles kasulikud tolmeldajad looduses." },
                new Animal { Name = "Kiil", Image = "vagrant_darter.png", Description = "Kiil on kiire ja osav lendaja, kes elab Eestis peamiselt veekogude ja metsade lähedal. Nad on tuntud oma dramaatilise värvuse ja kiire lendamise poolest, mis aitab neil kiskjate eest põgeneda. Kiilid toituvad peamiselt teistest putukatest, olles olulised loomade toiduahelas." },
                new Animal { Name = "Kuldpõrnikas", Image = "rose_chafe.png", Description = "Kuldpõrnikas on elegantne ja silmapaistev putukas, kes elab Eestis peamiselt õitsvates rohumaades ja metsades. Nad toituvad lehtedest ja õitest, olles kasulikud tolmeldajad. Kuldpõrnikate erksad värvid aitavad neil kiskjate eest varjuda, muutes nad looduses kütkestavaks vaateks." },
                new Animal { Name = "Päevasuru", Image = "hummingbird_hawk_moth.png", Description = "Päevasuru on ööputukas, kes elab Eestis peamiselt niisketes kohtades ja ilmub, kui päev hakkab hämarama. Nad sulanduvad hästi ümbritsevasse keskkonda, mis aitab neil kiskjate eest varjuda. Päevasurud toituvad nektarist ja väikestest putukatest, olles looduslike ökosüsteemide väärtuslikud liikmed." },
                new Animal { Name = "Vapsik", Image = "european_hornet.png", Description = "Vapsikuid kohtab sageli Eesti metsades ja aedades, kus nad on olulised ökosüsteemi osad, hoides kahjuripopulatsioonid kontrolli all.\r\nVapsik on suur ja silmapaistev putukas, kes elab kolooniates ning järgib selget sotsiaalset struktuuri. Nad on tuntud oma agressiivse käitumise poolest, kaitstes oma pesasid kiskjate eest. Vapsikud toituvad peamiselt teistest putukatest ja taimede nektarist, olles olulised ökosüsteemi tasakaalu hoidjad." },
                new Animal { Name = "Herilane", Image = "wasp.png", Description = "Herilane on suur ja agressiivne putukas, kes elab kolooniates ja kaitseb oma pesasid kiskjate eest. Nad toituvad peamiselt teistest putukatest, olles tõhusad kahjurite kontrollijad. Herilaste kohalolek metsaelustikus toob esile sotsiaalse koostöö ja ühtekuuluvuse." },
                new Animal { Name = "Lehetäi", Image = "aphid.png", Description = "Lehetäid elavad Eestis mitmesugustes taimestikurikastes piirkondades, sealhulgas aedades, metsades ja põldudel. Nad toituvad peamiselt taimemahlast, torkides oma suuosadega taimede lehti ja varsi. Kuigi lehetäid võivad olla kahjurid, on nad samas toiduks paljudele teistele loomadele, aidates sellega kaasa looduse tasakaalu hoidmisele." },
                new Animal { Name = "Sääsk", Image = "mosquito.png", Description = "Eestis suve osaks on sääsed, keda kohtab eriti palju niiskete alade ja veekogude lähedal.\r\nNende häiriv inin ja toitumine vere kaudu teevad nad kiskjate, sealhulgas lindude ja teiste putukate, sihtmärkideks. Sääsed toituvad peamiselt toidust, mis on vajalik nende arenguks ja paljunemiseks." },
                new Animal { Name = "Kevad-udeselg", Image = "common_quaker_moth.png", Description = "Kevad-udeselg ilmub Eestis esimesena kevadel, kui looduses hakkavad toimuma muutused. Nad elavad peamiselt niisketes kohtades, kus leidub rohkelt toitu. Kevad-udeselja kiired liigutused ja osav toiduotsimine aitavad neil ellu jääda, muutes nad looduse aktiivseteks osalisteks." }

            };

            BindingContext = this;
        }

        async void OnInsectSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedInsect)
            {
                await Navigation.PushAsync(new InsectsDetailsPage(selectedInsect));
            }
        }
    }
}
