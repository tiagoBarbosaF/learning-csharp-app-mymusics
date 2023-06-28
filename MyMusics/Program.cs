#region App My Playlist

using MyMusics.Menus;
using MyMusics.Models.Bands;

#region Mock

var registerBands = new Dictionary<string, Band>
{
    { "Millet", new Band("Millet", new List<Appraisal> { new(10), new(8), new(6) }) },
    { "Beatles", new Band("Beatles", new List<Appraisal> { new(5), new(8), new(10) }) },
    { "Neo Japonism", new Band("Neo Japonism", new List<Appraisal> { new(10), new(7) }) },
    { "Doul", new Band("Doul", new List<Appraisal> { new(10), new(9), new(6), new(7), new(8) }) }
};

var band = registerBands["Millet"];

var music = new Music("One Reason", band, 255, true);
var music2 = new Music("Walkin' In My Lane", band, 241, false);
var music3 = new Music("Love When I Cry", band, 199, true);
var music4 = new Music("One Reason", band, 270, true);
var music5 = new Music("Walkin' In My Lane", band, 241, false);
var music6 = new Music("Love When I Cry", band, 230, true);

var album = new Album("Walkin' In My Lane", new Gender("Pop"));
var album2 = new Album("Eyes", new Gender("Pop"));
album.AddMusic(music);
album.AddMusic(music2);
album.AddMusic(music3);
album2.AddMusic(music4);
album2.AddMusic(music5);
album2.AddMusic(music6);

band.AddAlbums(album);
band.AddAlbums(album2);

#endregion

while (Menu.exit)
{
    Console.Clear();

    Menu.MenuOptions();
    
    var chosenOption = Menu.ChosenOption;

    Menu.OptionsMenu(chosenOption, registerBands);
}

#endregion

#region Register Musics

//
// using MyMusics.Classes.Bands;
// using MyMusics.Classes.Podcasts;
//
// var music = new Music("One Reason", new Band("Millet"), 255, true);
// var music2 = new Music("Walkin' In My Lane", new Band("Millet"), 241, false);
// var music3 = new Music("Love When I Cry", new Band("Millet"), 199, true);
//
// var album = new Album("Walkin' In My Lane", new Gender("Pop"));
// album.AddMusic(music);
// album.AddMusic(music2);
// album.AddMusic(music3);
//
// var band = new Band("Millet");
//
// band.AddAlbums(album);
//
// band.ShowDiscography();
//
// Console.WriteLine("\n-----------------------------------------\n");
//
// var episode1 = new Episodes(1, "Introdução à Inteligência Artificial", 3700);
// episode1.AddGuests("John Smith");
// episode1.AddGuests("Emily Johnson");
//
// var episode3 = new Episodes(3, "Segurança Cibernética e Proteção de Dados", 3000);
// episode3.AddGuests("David Ramirez");
// episode3.AddGuests("Lisa Chen");
//
// var episode5 = new Episodes(5, "Desenvolvimento de Aplicativos para Smartphones", 3000);
// episode5.AddGuests("Robert Johnson");
// episode5.AddGuests("Megan Wilson");
// episode5.AddGuests("Sarah Thompson");
//
// var episode2 = new Episodes(2, "O Futuro da Realidade Virtual", 3600);
// episode2.AddGuests("Michael Anderson");
// episode2.AddGuests("Sarah Thompson");
//
// var episode4 = new Episodes(4, "Tendências em Dispositivos Móveis", 3300);
// episode4.AddGuests("Mark Davis");
// episode4.AddGuests("Jessica Lee");
//
// var podcast = new Podcast("Tech Talk", "Lucas Silva");
// podcast.AddEpisodes(episode4);
// podcast.AddEpisodes(episode2);
// podcast.AddEpisodes(episode5);
// podcast.AddEpisodes(episode1);
// podcast.AddEpisodes(episode3);
//
// podcast.ShowDetails();
//

#endregion