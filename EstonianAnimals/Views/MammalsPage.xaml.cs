using System.Collections.ObjectModel;
using EstonianAnimals.Models;


namespace EstonianAnimals.Views
{
    public partial class MammalsPage : ContentPage
    {
        public ObservableCollection<Animal> Mammals { get; set; }

        public MammalsPage()
        {
            InitializeComponent();

            Mammals = new ObservableCollection<Animal>
            {
                new Animal { Name = "Hunt", Image = "wolf.png", Description = "Hunt on Eesti metsade suurim kiskja, keda austatakse tema intelligentsuse ja keeruka sotsiaalse struktuuri poolest. Nad elavad tavaliselt karjadena, j�rgides kindlat hierarhiat. Hundi ulgumine on �ks Eesti metsade ikoonilisemaid helisid." },
                new Animal { Name = "Karu", Image = "bear.png", Description = "Karu on Eesti suurim kiskja, kes on tuntud oma j�u ja vastupidavuse poolest. Talveks kogub karu rasvavarusid ja veedab talve talveunes. Nad elavad tavaliselt �ksikuna ja on omnivoorid, s��es nii taimi kui ka liha." },
                new Animal { Name = "Ilves", Image = "lynx.png", Description = "Ilves on salap�rane ja �ksildane loom, keda v�ib kohata Eesti metsades. Tema t�piline karv aitab tal looduses h�sti sulanduda. Ilvesed on suurep�rased jahimehed, kes p��avad oma saaki varitsedes." },
                new Animal { Name = "Rebane", Image = "fox.png", Description = "Rebane on tuntud oma kavaluse ja kohanemisv�ime poolest. Nad elavad mitmesugustes elupaikades, sealhulgas metsades ja p�ldudel. Rebane on oportunistlik toitumises ja s��b peaaegu k�ike, mida leiab." },
                new Animal { Name = "P�der", Image = "moose.png", Description = "P�der on Eesti suurim maismaa imetaja, tuntud oma suurte sarvede ja tugeva kehaga. Nad elavad metsades ja soodes ning toituvad peamiselt lehtedest ja p��sastest. P�drad on sageli �ksildased, kuid paaritumishooajal v�itlevad isased omavahel �iguse eest paarituda." },
                new Animal { Name = "Metskits", Image = "roe_deer.png", Description = "Metskits on v�ike ja graatsiline loom, keda v�ib sageli n�ha avamaastikul ja metsaservades. Nad on tuntud oma kiire liikumise ja ettevaatlikkuse poolest. Metskitsed on taimtoidulised, toituvad rohust ja noortest v�rsetest." },
                new Animal { Name = "J�nes", Image = "hare.png", Description = "J�nes on tuntud oma kiire jooksu ja osava varjumise poolest, mist�ttu on ta kiskjate eest h�sti kaitstud. Nad elavad metsades ja p�llumaadel ning v�ivad liikuda suure kiirusega, kui neid �hvardatakse. J�nesed toituvad peamiselt rohttaimedest ja koorest." },
                new Animal { Name = "Kobras", Image = "beaver.png", Description = "Kobras on tuntud oma oskuse poolest ehitada tamme, mis muudavad veekogude voolu. Nad elavad tihedates pere�ksustes ja veedavad palju aega vee l�heduses. Kobraste tegevus aitab kujundada maastikku ja parandada vee �kos�steemi." },
                new Animal { Name = "Siil", Image = "hedgehog.png", Description = "Siil on �ine loom, keda kaitsevad tema teravad okkad, kui ta end kerra t�mbab. Siilid toituvad putukatest, tigudest ja v�ikestest selgrootutest. Nad veedavad talve talveunes ja �rkavad kevadel, kui ilm soojeneb." },
                new Animal { Name = "Orav", Image = "squirrel.png", Description = "Orav on osav ronija, keda v�ib sageli n�ha puude otsas seemneid kogumas. Nad on tuntud oma karvase saba ja energilise loomuse poolest. Oravad aitavad kaasa metsade levikule, peites seemneid, mida nad hiljem ei pruugi leida." }

            };

            BindingContext = this;
        }

        async void OnMammalSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedMammal)
            {
                await Navigation.PushAsync(new MammalDetailsPage(selectedMammal));
            }
        }
    }
}
