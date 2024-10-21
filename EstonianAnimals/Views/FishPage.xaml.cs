using System.Collections.ObjectModel;
using EstonianAnimals.Models;

namespace EstonianAnimals.Views
{
    public partial class FishPage : ContentPage
    {
        public ObservableCollection<Animal> Fishes { get; set; }

        public FishPage()
        {
            InitializeComponent();

            Fishes = new ObservableCollection<Animal>
            {
                new Animal { Name = "Ahven", Image = "ahven.png", Description = "Ahven on Eesti vetes laialt levinud kalaliik, tuntud oma iseloomulike mustade triipude ja roheka varjundi poolest. Nad elavad tavaliselt mageveekogudes, nagu järved ja jõed, ning eelistavad elupaiku, kus on rohke taimestik. Ahven on röövkala, kes toitub peamiselt väiksematest kaladest ja putukatest. Nad on väga kohanemisvõimelised ja on populaarsed ka kalapüügis, kuna pakuvad tugevat vastupanu ja on maitsva lihaga." },
                new Animal { Name = "Haug", Image = "haug.png", Description = "Haug on Eesti suurim röövkala, keda võib leida peaaegu kõigis suuremates järvedes ja jõgedes. Ta on tuntud oma pikliku keha ja teravate hammastega tugeva lõuaga, mis teevad temast osava kiskja. Haug on üksildane kiskja, kes varitseb saaki taimestiku vahel ja ründab kiire välgatusena. Tavaliselt toitub ta teistest kaladest, konnadest ja isegi väiksematest imetajatest. Haug on oluline osa Eesti kalapüügikultuurist, olles kalameeste seas hinnatud trofee oma suuruse ja vastupanuvõime tõttu." },
                new Animal { Name = "Koha", Image = "koha.png", Description = "Koha on Eesti vetes hinnatud röövkala, keda võib leida peamiselt suurtest järvedest ja jõgedest. Ta on tuntud oma pikliku keha, teravate hammaste ja hõbedase-rohelise värvuse poolest, millel on iseloomulikud tumedad täpid külgedel. Koha elutseb sügavamates vetes ja jahtib peamiselt öösiti, kasutades oma hästi arenenud nägemist saagi püüdmise ajal. Toiduks eelistab ta väiksemaid kalu ja koorikloomi. Koha on kalapüüdjate seas populaarne oma delikaatse ja maitsva liha poolest, tehes temast ühe ihaldatuma kalaliigi Eesti kalapüügikohtades." },
                new Animal { Name = "Latikas", Image = "latikas.png", Description = "Latikas on Eesti vetes laialt levinud ja tuntud oma lameda kehakuju ning kuldse-pronksja värvuse poolest. Latikad eelistavad elada aeglaselt voolavates jõgedes, järvedes ja tiikides, kus nad kogunevad tihti suurtesse parvedesse. Nad toituvad peamiselt vetikate, taimede ja põhjaloomade, nagu väikesed koorikloomad ja putukavastsed, kraapimisest veekogu põhjast. Latikas on kalameeste seas hinnatud peamiselt oma suure suuruse tõttu, kuna täiskasvanud isendid võivad kaaluda mitmeid kilosid. Samuti on ta tuntud oma võitluse poolest, kui ta konksu otsa jääb, pakkudes kalameestele põnevat püügihetke." },
                new Animal { Name = "Särg", Image = "sarg.png", Description = "Särg on üks Eesti levinumaid kalu, keda võib kohata peaaegu kõigis mageveekogudes, nagu järved, jõed ja tiigid. Ta on hõbedase värvusega, sageli punaste uimedega kala, kes elutseb parvedes ja on väga kohanemisvõimeline. Särjed toituvad peamiselt vetikatest, planktonist ja väikestest selgrootutest, kraapides toitu veekogu põhjast või taimestikult. Kuigi särg on väike ja tagasihoidliku välimusega kala, on ta kalameeste seas populaarne, eriti talipüügil, kus ta on sageli esimene kala, kes konksu otsa jääb. Särjel on ka tähtis roll veekogude ökosüsteemis, aidates tasakaalustada toiduahelat." },
                new Animal { Name = "Kammeljas", Image = "kammeljas.png", Description = "Kammeljas on Eesti rannikuvetes elav põhjakala, tuntud oma lapiku keha ja oskuse poolest end liiva sisse peita. Ta on pruunika varjundiga ja suudab värvi muuta, et sulanduda paremini oma keskkonda, mis teeb temast osava varitseja. Kammeljas elutseb peamiselt madalates vetes ja liivastel või mudastel põhjadel, kus ta jahtib väikeseid kalu, koorikloomi ja molluskeid. Tema silmad paiknevad ühel keha küljel, mis võimaldab tal püsida liikumatult põhjas, oodates saaki. Kammeljas on ka hinnatud kala gastronoomias, olles tuntud oma maheda ja õrna liha poolest." },
                new Animal { Name = "Tursk", Image = "tursk.png", Description = "Tursk on Põhja-Euroopa ja Eesti ranniku vetes levinud kala, keda hinnatakse nii kalapüügi kui ka kulinaarse väärtuse poolest. Ta on suure kasvuga ja iseloomuliku pruunika-hallika värvusega kala, kellel on sageli kergelt laiguline keha ja kahvatu kõht. Tursk eelistab elada külmades ja sügavates vetes, kuid liigub sageli ka madalamatesse piirkondadesse toidu otsingul. Ta on röövkala, kelle toidulauale kuuluvad väiksemad kalad, koorikloomad ja peajalgsed. Tursk on toiduvalmistamisel tuntud oma valge, helbelise ja mahedamaitselise liha poolest, mis teeb temast populaarse koostisosa erinevates roogades, sealhulgas kalasuppides ja ahjuroogades." },
                new Animal { Name = "Vikerforell", Image = "vikerforell.png", Description = "Vikerforell on värvikas ja maitsev mageveekala, keda kasvatatakse laialdaselt ka Eesti vetes. Ta on tuntud oma särava roosa või punase värvuse poolest, millel on mustad laigud üle kogu keha, ja ilusate roosade uimedega. Vikerforell elab tavaliselt puhtas ja jahedas vees, nagu jõed ja järved, kus ta toitub peamiselt väikestest kaladest, putukatest ja nende vastsetest. Ta on aktiivne ja kiire kala, mis teeb temast populaarse sihtmärgi kalameestele, kuna ta pakub intensiivset võitlust ja on maitsva lihaga. Vikerforelli liha on valge ja õrn, mistõttu on ta hinnatud ka kulinaaria maailmas, olles sagedane komponent erinevates roogades ja valmistamisviisides." },
                new Animal { Name = "Lõhe", Image = "lohe.png", Description = "Lõhe on üks hinnatumaid ja ikoonilisemaid kalu, kes elab Eesti vetes, eelkõige jõgedes ja meres. Tuntud oma särava roosa või oranşi värvuse ja silmapaistvate mustade laikude poolest, on lõhe ka tuntud oma suure suuruse ja kauni kuju poolest. Lõhe on rändkalana tuntud, et ta migreerib jõgedesse kudema, kus ta sünnib ja seejärel naaseb merele, et kasvada ja toituda väikestest kaladest ning koorikloomadest. Lõhe liha on rikkalik ja maitsev, olles küllastunud omega-3-rasvhapetega, mis muudab selle tervislikuks ja ihaldatud toiduks. Ta on populaarne mitte ainult kalameeste seas, vaid ka kulinaaria maailmas, olles levinud roogades, nagu suitsulõhe, grillitud lõhe ja lõhesupp. Lõhe on samuti kultuuriliselt oluline, olles Eesti traditsioonilises köögis ja kalapüügis olulisel kohal." },
                new Animal { Name = "Angerjas", Image = "angerjas.png", Description = "Angerjas on salapärane ja ainulaadne mageveekala, keda võib leida peamiselt Eestimaa jõgedes ja järvedes. Ta on tuntud oma pikliku, ebatavalise keha ja limase nahka poolest, mis muudab ta sarnaseks maod. Angerjas elab peamiselt põhjas, kus ta peidab end liiva või mudaga, oodates saaki. Ta on öine kiskja, kes toitub peamiselt väikestest kaladest, koorikloomadest ja putukatest, kasutades oma teravaid hambaid saagi püüdmiseks. Angerjas on ka populaarne kalapüügiviis, kuna tema liha on maitsev ja toitev. Angerjat peetakse traditsiooniliselt delikatessiks, mida valmistatakse erinevates roogades, sealhulgas hautistes ja grillitud vormides. Samuti on ta tuntud oma erakordse rändevõime poolest, suudades leida teed ookeani, et kudeda ja seejärel tagasi mageveekogudesse naasta." }
            };

            BindingContext = this;
        }

        async void OnFishSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedFish)
            {
                await Navigation.PushAsync(new FishDetailsPage(selectedFish));
            }
        }
    }
}
