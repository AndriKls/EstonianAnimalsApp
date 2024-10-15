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
                new Animal { Name = "Hunt", Image = "wolf.png", Description = "Hunt on Eesti metsade suurim kiskja, keda austatakse tema intelligentsuse ja keeruka sotsiaalse struktuuri poolest. Nad elavad tavaliselt karjadena, järgides kindlat hierarhiat. Hundi ulgumine on üks Eesti metsade ikoonilisemaid helisid." },
                new Animal { Name = "Karu", Image = "bear.png", Description = "Karu on Eesti suurim kiskja, kes on tuntud oma jõu ja vastupidavuse poolest. Talveks kogub karu rasvavarusid ja veedab talve talveunes. Nad elavad tavaliselt üksikuna ja on omnivoorid, süües nii taimi kui ka liha." },
                new Animal { Name = "Ilves", Image = "lynx.png", Description = "Ilves on salapärane ja üksildane loom, keda võib kohata Eesti metsades. Tema täpiline karv aitab tal looduses hästi sulanduda. Ilvesed on suurepärased jahimehed, kes püüavad oma saaki varitsedes." },
                new Animal { Name = "Rebane", Image = "fox.png", Description = "Rebane on tuntud oma kavaluse ja kohanemisvõime poolest. Nad elavad mitmesugustes elupaikades, sealhulgas metsades ja põldudel. Rebane on oportunistlik toitumises ja sööb peaaegu kõike, mida leiab." },
                new Animal { Name = "Põder", Image = "moose.png", Description = "Põder on Eesti suurim maismaa imetaja, tuntud oma suurte sarvede ja tugeva kehaga. Nad elavad metsades ja soodes ning toituvad peamiselt lehtedest ja põõsastest. Põdrad on sageli üksildased, kuid paaritumishooajal võitlevad isased omavahel õiguse eest paarituda." },
                new Animal { Name = "Metskits", Image = "roe_deer.png", Description = "Metskits on väike ja graatsiline loom, keda võib sageli näha avamaastikul ja metsaservades. Nad on tuntud oma kiire liikumise ja ettevaatlikkuse poolest. Metskitsed on taimtoidulised, toituvad rohust ja noortest võrsetest." },
                new Animal { Name = "Jänes", Image = "hare.png", Description = "Jänes on tuntud oma kiire jooksu ja osava varjumise poolest, mistõttu on ta kiskjate eest hästi kaitstud. Nad elavad metsades ja põllumaadel ning võivad liikuda suure kiirusega, kui neid ähvardatakse. Jänesed toituvad peamiselt rohttaimedest ja koorest." },
                new Animal { Name = "Kobras", Image = "beaver.png", Description = "Kobras on tuntud oma oskuse poolest ehitada tamme, mis muudavad veekogude voolu. Nad elavad tihedates pereüksustes ja veedavad palju aega vee läheduses. Kobraste tegevus aitab kujundada maastikku ja parandada vee ökosüsteemi." },
                new Animal { Name = "Siil", Image = "hedgehog.png", Description = "Siil on öine loom, keda kaitsevad tema teravad okkad, kui ta end kerra tõmbab. Siilid toituvad putukatest, tigudest ja väikestest selgrootutest. Nad veedavad talve talveunes ja ärkavad kevadel, kui ilm soojeneb." },
                new Animal { Name = "Orav", Image = "squirrel.png", Description = "Orav on osav ronija, keda võib sageli näha puude otsas seemneid kogumas. Nad on tuntud oma karvase saba ja energilise loomuse poolest. Oravad aitavad kaasa metsade levikule, peites seemneid, mida nad hiljem ei pruugi leida." }

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
