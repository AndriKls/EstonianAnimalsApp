using System.Collections.ObjectModel;
using EstonianAnimals.Models;


namespace EstonianAnimals.Views
{
    public partial class BirdsPage : ContentPage
    {
        public ObservableCollection<Animal> Birds { get; set; }

        public BirdsPage()
        {
            InitializeComponent();

            Birds = new ObservableCollection<Animal>
            {
                new Animal { Name = "Rasvatihane", Image = "greattit.png", Description = "Rasvatihane on linnuliik tihaslaste sugukonnast. Ta on Eesti ¸ks tavalisemaid ja tuntumaid linde ning ¸ks pıhjalikumalt uuritud linnuliike maailmas. Lisaks on ta Eestis arvukaim talvitaja. Rasvatihane oli Eesti 2016. aasta lind." },
                new Animal { Name = "Suitsup‰‰suke", Image = "barnswallow.png", Description = "Suitsup‰‰suke on p‰‰sulaste sugukonda kuuluv v‰ike r‰ndlind. Suitsup‰‰suke on kıige suurema levilaga p‰‰sulane. Ta on levinud haudelind Euroopas, Aasias, Pıhja-Aafrikas ja Pıhja-Ameerikas. Suitsup‰‰suke on Eesti ja oli aastatel 1962ñ1964 Austria rahvuslind." },
                new Animal { Name = "Koduvarblane", Image = "housesparrow.png", Description = "Koduvarblane on linnuliik v‰rvuliste seltsist, varblaslaste sugukonnast. Koduvarblane on looduslikult levinud valdavas osas Euraasias. Ta on inimkaasleja ja teda on alates 19. sajandi keskpaigast introdutseeritud Ameerikasse, Aafrikasse Saharast lıuna pool, Uus-Meremaale ja Austraaliasse ning paljudesse maailma linnadesse, et asendada v‰ljar‰nnanud liike." },
                new Animal { Name = "Hallvares", Image = "hoodedcrow.png", Description = "Hallvares on v‰rvuliste seltsi vareslaste sugukonda kuuluv liik linde. Hallvares on levinud Euraasias Iirimaast, äotimaast, Skandinaaviast ja Mandri-Euroopa kesk- ja lıunaosadest kuni L‰‰ne-Siberini. Hallvareste arvukus aasta-aastalt kasvab ja paljude teiste linnalindude arvukus selle vırra v‰heneb." },
                new Animal { Name = "Suur-kirjur‰hn", Image = "greatspottedwoodpecker.png", Description = "Suur-kirjur‰hn on Eesti levinuim r‰hniliik. Kuulub kirjur‰hni perekonda. Suur-kirjur‰hni pesitsusaegset arvukust hinnatakse 50 000 ñ 100 000 paarile, talvist arvukust 50 000 ñ 300 000 isendile." },
            };

            BindingContext = this;
        }

        async void OnBirdSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal selectedBird)
            {
                await Navigation.PushAsync(new BirdsDetailsPage(selectedBird));
            }
        }
    }
}
