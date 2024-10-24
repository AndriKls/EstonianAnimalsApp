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
                new Animal { Name = "Rohutirts", Image = "grasshopper.png", Description = "Rohutirtsud elavad Eestis rohkete rohumaade ja metsade vahel. Rohutirtsud toituvad peamiselt rohust ja taimedest, olles samal ajal olulised looduslike tasakaalude s�ilitajad." },
                new Animal { Name = "Maakimalane", Image = "buff_tailed_bumblebee.png", Description = "Maakimalane on Eestis laialt levinud, eriti L��ne- ja L�una-Eestis, kus nad tolmeldavad kohalikke taimi ja �istaimi.\r\nMaakimalane on tuntud oma s�rava v�rvi ja unikaalse kehaehituse poolest, olles sageli m�rk keskkonna puhtusest. Nad elavad peamiselt metsades ja rohumaadel, kus nad saavad toitu otsida ja peidus olla. Maakimalased toituvad peamiselt �itest ja lehtedest, olles kasulikud tolmeldajad looduses." },
                new Animal { Name = "Kiil", Image = "vagrant_darter.png", Description = "Kiil on kiire ja osav lendaja, kes elab Eestis peamiselt veekogude ja metsade l�hedal. Nad on tuntud oma dramaatilise v�rvuse ja kiire lendamise poolest, mis aitab neil kiskjate eest p�geneda. Kiilid toituvad peamiselt teistest putukatest, olles olulised loomade toiduahelas." },
                new Animal { Name = "Kuldp�rnikas", Image = "rose_chafe.png", Description = "Kuldp�rnikas on elegantne ja silmapaistev putukas, kes elab Eestis peamiselt �itsvates rohumaades ja metsades. Nad toituvad lehtedest ja �itest, olles kasulikud tolmeldajad. Kuldp�rnikate erksad v�rvid aitavad neil kiskjate eest varjuda, muutes nad looduses k�tkestavaks vaateks." },
                new Animal { Name = "P�evasuru", Image = "hummingbird_hawk_moth.png", Description = "P�evasuru on ��putukas, kes elab Eestis peamiselt niisketes kohtades ja ilmub, kui p�ev hakkab h�marama. Nad sulanduvad h�sti �mbritsevasse keskkonda, mis aitab neil kiskjate eest varjuda. P�evasurud toituvad nektarist ja v�ikestest putukatest, olles looduslike �kos�steemide v��rtuslikud liikmed." },
                new Animal { Name = "Vapsik", Image = "european_hornet.png", Description = "Vapsikuid kohtab sageli Eesti metsades ja aedades, kus nad on olulised �kos�steemi osad, hoides kahjuripopulatsioonid kontrolli all.\r\nVapsik on suur ja silmapaistev putukas, kes elab kolooniates ning j�rgib selget sotsiaalset struktuuri. Nad on tuntud oma agressiivse k�itumise poolest, kaitstes oma pesasid kiskjate eest. Vapsikud toituvad peamiselt teistest putukatest ja taimede nektarist, olles olulised �kos�steemi tasakaalu hoidjad." },
                new Animal { Name = "Herilane", Image = "wasp.png", Description = "Herilane on suur ja agressiivne putukas, kes elab kolooniates ja kaitseb oma pesasid kiskjate eest. Nad toituvad peamiselt teistest putukatest, olles t�husad kahjurite kontrollijad. Herilaste kohalolek metsaelustikus toob esile sotsiaalse koost�� ja �htekuuluvuse." },
                new Animal { Name = "Lehet�i", Image = "aphid.png", Description = "Lehet�id elavad Eestis mitmesugustes taimestikurikastes piirkondades, sealhulgas aedades, metsades ja p�ldudel. Nad toituvad peamiselt taimemahlast, torkides oma suuosadega taimede lehti ja varsi. Kuigi lehet�id v�ivad olla kahjurid, on nad samas toiduks paljudele teistele loomadele, aidates sellega kaasa looduse tasakaalu hoidmisele." },
                new Animal { Name = "S��sk", Image = "mosquito.png", Description = "Eestis suve osaks on s��sed, keda kohtab eriti palju niiskete alade ja veekogude l�hedal.\r\nNende h�iriv inin ja toitumine vere kaudu teevad nad kiskjate, sealhulgas lindude ja teiste putukate, sihtm�rkideks. S��sed toituvad peamiselt toidust, mis on vajalik nende arenguks ja paljunemiseks." },
                new Animal { Name = "Kevad-udeselg", Image = "common_quaker_moth.png", Description = "Kevad-udeselg ilmub Eestis esimesena kevadel, kui looduses hakkavad toimuma muutused. Nad elavad peamiselt niisketes kohtades, kus leidub rohkelt toitu. Kevad-udeselja kiired liigutused ja osav toiduotsimine aitavad neil ellu j��da, muutes nad looduse aktiivseteks osalisteks." }

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
