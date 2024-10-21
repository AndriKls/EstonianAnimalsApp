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
                new Animal { Name = "Ahven", Image = "ahven.png", Description = "Ahven on Eesti vetes laialt levinud kalaliik, tuntud oma iseloomulike mustade triipude ja roheka varjundi poolest. Nad elavad tavaliselt mageveekogudes, nagu j�rved ja j�ed, ning eelistavad elupaiku, kus on rohke taimestik. Ahven on r��vkala, kes toitub peamiselt v�iksematest kaladest ja putukatest. Nad on v�ga kohanemisv�imelised ja on populaarsed ka kalap��gis, kuna pakuvad tugevat vastupanu ja on maitsva lihaga." },
                new Animal { Name = "Haug", Image = "haug.png", Description = "Haug on Eesti suurim r��vkala, keda v�ib leida peaaegu k�igis suuremates j�rvedes ja j�gedes. Ta on tuntud oma pikliku keha ja teravate hammastega tugeva l�uaga, mis teevad temast osava kiskja. Haug on �ksildane kiskja, kes varitseb saaki taimestiku vahel ja r�ndab kiire v�lgatusena. Tavaliselt toitub ta teistest kaladest, konnadest ja isegi v�iksematest imetajatest. Haug on oluline osa Eesti kalap��gikultuurist, olles kalameeste seas hinnatud trofee oma suuruse ja vastupanuv�ime t�ttu." },
                new Animal { Name = "Koha", Image = "koha.png", Description = "Koha on Eesti vetes hinnatud r��vkala, keda v�ib leida peamiselt suurtest j�rvedest ja j�gedest. Ta on tuntud oma pikliku keha, teravate hammaste ja h�bedase-rohelise v�rvuse poolest, millel on iseloomulikud tumedad t�pid k�lgedel. Koha elutseb s�gavamates vetes ja jahtib peamiselt ��siti, kasutades oma h�sti arenenud n�gemist saagi p��dmise ajal. Toiduks eelistab ta v�iksemaid kalu ja koorikloomi. Koha on kalap��djate seas populaarne oma delikaatse ja maitsva liha poolest, tehes temast �he ihaldatuma kalaliigi Eesti kalap��gikohtades." },
                new Animal { Name = "Latikas", Image = "latikas.png", Description = "Latikas on Eesti vetes laialt levinud ja tuntud oma lameda kehakuju ning kuldse-pronksja v�rvuse poolest. Latikad eelistavad elada aeglaselt voolavates j�gedes, j�rvedes ja tiikides, kus nad kogunevad tihti suurtesse parvedesse. Nad toituvad peamiselt vetikate, taimede ja p�hjaloomade, nagu v�ikesed koorikloomad ja putukavastsed, kraapimisest veekogu p�hjast. Latikas on kalameeste seas hinnatud peamiselt oma suure suuruse t�ttu, kuna t�iskasvanud isendid v�ivad kaaluda mitmeid kilosid. Samuti on ta tuntud oma v�itluse poolest, kui ta konksu otsa j��b, pakkudes kalameestele p�nevat p��gihetke." },
                new Animal { Name = "S�rg", Image = "sarg.png", Description = "S�rg on �ks Eesti levinumaid kalu, keda v�ib kohata peaaegu k�igis mageveekogudes, nagu j�rved, j�ed ja tiigid. Ta on h�bedase v�rvusega, sageli punaste uimedega kala, kes elutseb parvedes ja on v�ga kohanemisv�imeline. S�rjed toituvad peamiselt vetikatest, planktonist ja v�ikestest selgrootutest, kraapides toitu veekogu p�hjast v�i taimestikult. Kuigi s�rg on v�ike ja tagasihoidliku v�limusega kala, on ta kalameeste seas populaarne, eriti talip��gil, kus ta on sageli esimene kala, kes konksu otsa j��b. S�rjel on ka t�htis roll veekogude �kos�steemis, aidates tasakaalustada toiduahelat." },
                new Animal { Name = "Kammeljas", Image = "kammeljas.png", Description = "Kammeljas on Eesti rannikuvetes elav p�hjakala, tuntud oma lapiku keha ja oskuse poolest end liiva sisse peita. Ta on pruunika varjundiga ja suudab v�rvi muuta, et sulanduda paremini oma keskkonda, mis teeb temast osava varitseja. Kammeljas elutseb peamiselt madalates vetes ja liivastel v�i mudastel p�hjadel, kus ta jahtib v�ikeseid kalu, koorikloomi ja molluskeid. Tema silmad paiknevad �hel keha k�ljel, mis v�imaldab tal p�sida liikumatult p�hjas, oodates saaki. Kammeljas on ka hinnatud kala gastronoomias, olles tuntud oma maheda ja �rna liha poolest." },
                new Animal { Name = "Tursk", Image = "tursk.png", Description = "Tursk on P�hja-Euroopa ja Eesti ranniku vetes levinud kala, keda hinnatakse nii kalap��gi kui ka kulinaarse v��rtuse poolest. Ta on suure kasvuga ja iseloomuliku pruunika-hallika v�rvusega kala, kellel on sageli kergelt laiguline keha ja kahvatu k�ht. Tursk eelistab elada k�lmades ja s�gavates vetes, kuid liigub sageli ka madalamatesse piirkondadesse toidu otsingul. Ta on r��vkala, kelle toidulauale kuuluvad v�iksemad kalad, koorikloomad ja peajalgsed. Tursk on toiduvalmistamisel tuntud oma valge, helbelise ja mahedamaitselise liha poolest, mis teeb temast populaarse koostisosa erinevates roogades, sealhulgas kalasuppides ja ahjuroogades." },
                new Animal { Name = "Vikerforell", Image = "vikerforell.png", Description = "Vikerforell on v�rvikas ja maitsev mageveekala, keda kasvatatakse laialdaselt ka Eesti vetes. Ta on tuntud oma s�rava roosa v�i punase v�rvuse poolest, millel on mustad laigud �le kogu keha, ja ilusate roosade uimedega. Vikerforell elab tavaliselt puhtas ja jahedas vees, nagu j�ed ja j�rved, kus ta toitub peamiselt v�ikestest kaladest, putukatest ja nende vastsetest. Ta on aktiivne ja kiire kala, mis teeb temast populaarse sihtm�rgi kalameestele, kuna ta pakub intensiivset v�itlust ja on maitsva lihaga. Vikerforelli liha on valge ja �rn, mist�ttu on ta hinnatud ka kulinaaria maailmas, olles sagedane komponent erinevates roogades ja valmistamisviisides." },
                new Animal { Name = "L�he", Image = "lohe.png", Description = "L�he on �ks hinnatumaid ja ikoonilisemaid kalu, kes elab Eesti vetes, eelk�ige j�gedes ja meres. Tuntud oma s�rava roosa v�i oran�i v�rvuse ja silmapaistvate mustade laikude poolest, on l�he ka tuntud oma suure suuruse ja kauni kuju poolest. L�he on r�ndkalana tuntud, et ta migreerib j�gedesse kudema, kus ta s�nnib ja seej�rel naaseb merele, et kasvada ja toituda v�ikestest kaladest ning koorikloomadest. L�he liha on rikkalik ja maitsev, olles k�llastunud omega-3-rasvhapetega, mis muudab selle tervislikuks ja ihaldatud toiduks. Ta on populaarne mitte ainult kalameeste seas, vaid ka kulinaaria maailmas, olles levinud roogades, nagu suitsul�he, grillitud l�he ja l�hesupp. L�he on samuti kultuuriliselt oluline, olles Eesti traditsioonilises k��gis ja kalap��gis olulisel kohal." },
                new Animal { Name = "Angerjas", Image = "angerjas.png", Description = "Angerjas on salap�rane ja ainulaadne mageveekala, keda v�ib leida peamiselt Eestimaa j�gedes ja j�rvedes. Ta on tuntud oma pikliku, ebatavalise keha ja limase nahka poolest, mis muudab ta sarnaseks maod. Angerjas elab peamiselt p�hjas, kus ta peidab end liiva v�i mudaga, oodates saaki. Ta on �ine kiskja, kes toitub peamiselt v�ikestest kaladest, koorikloomadest ja putukatest, kasutades oma teravaid hambaid saagi p��dmiseks. Angerjas on ka populaarne kalap��giviis, kuna tema liha on maitsev ja toitev. Angerjat peetakse traditsiooniliselt delikatessiks, mida valmistatakse erinevates roogades, sealhulgas hautistes ja grillitud vormides. Samuti on ta tuntud oma erakordse r�ndev�ime poolest, suudades leida teed ookeani, et kudeda ja seej�rel tagasi mageveekogudesse naasta." }
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
