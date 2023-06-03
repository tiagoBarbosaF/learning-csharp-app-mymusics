﻿// #region App My Playlist
//
// using MyMusics;
//
// const string welcomeMessage = "Welcome to My Playlist!";
// var exit = true;
// var chosenOption = "";
//
// var registerBands = new Dictionary<string, List<int>>
// {
//   {"Millet", new List<int> {10, 9, 10, 7}},
//   {"Beatles", new List<int> {5, 8, 10}},
//   {"Neo Japonism", new List<int> {10, 7}},
//   {"Doul", new List<int> {10, 9, 6, 7, 8}},
// };
//
// foreach (var test in registerBands.Values)
// {
//   Console.WriteLine(test);
// }
//
// void ShowWelcomeMessage()
// {
//   Console.WriteLine(@"
// █▀▄▀█ █▄█   █▀▄▀█ █░█ █▀ █ █▀▀ █▀
// █░▀░█ ░█░   █░▀░█ █▄█ ▄█ █ █▄▄ ▄█");
//   Console.WriteLine();
//   Console.WriteLine(welcomeMessage);
// }
//
// void Menu()
// {
//   ShowWelcomeMessage();
//   Console.WriteLine("\n- Enter 1 to register a band");
//   Console.WriteLine("- Enter 2 to list all bands");
//   Console.WriteLine("- Enter 3 to available a band");
//   Console.WriteLine("- Enter 4 to show an average of a band");
//   Console.WriteLine("- Enter 0 to exit");
//
//   Console.Write("\nEnter your option: ");
//   chosenOption = Console.ReadLine();
// }
//
// void OptionsMenu(string chosenOption)
// {
//   switch (chosenOption)
//   {
//     case "1":
//       RegisterBand();
//       break;
//     case "2":
//       ListBands();
//       break;
//     case "3":
//       AvailableBand();
//       break;
//     case "4":
//       AverageBandRate();
//       break;
//     case "0":
//       exit = false;
//       Console.WriteLine("\nSee you later!");
//       break;
//     default:
//       Console.WriteLine("\nChosen Option not available!");
//       break;
//   }
// }
//
// void RegisterBand()
// {
//   Console.Clear();
//
//   Console.WriteLine(@"
// █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀▀ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄
// █▀▄ ██▄ █▄█ █ ▄█ ░█░ ██▄ █▀▄   █▄█ █▀█ █░▀█ █▄▀
// ");
//
//   Console.Write($"\nEnter the band name for register: ");
//
//   var bandName = Console.ReadLine()!;
//
//   Console.WriteLine($"\nThe band {bandName} it's register successfully!");
//
//   registerBands.Add(bandName, new List<int>());
//
//   Console.ReadKey();
// }
//
// void ListBands()
// {
//   Console.Clear();
//
//   Console.WriteLine(@"
// █▄▄ ▄▀█ █▄░█ █▀▄ █▀   █░░ █ █▀ ▀█▀
// █▄█ █▀█ █░▀█ █▄▀ ▄█   █▄▄ █ ▄█ ░█░
// ");
//
//   Console.WriteLine();
//
//   foreach (var band in registerBands!)
//   {
//     Console.WriteLine($"- {band.Key}");
//     Console.WriteLine($"  Rate: {string.Join(", ", band.Value)}\n");
//   }
//
//   Console.ReadKey();
// }
//
// void AvailableBand()
// {
//   Console.Clear();
//
//   Console.WriteLine(@"
// ▄▀█ █░█ ▄▀█ █ █░░ ▄▀█ █▄▄ █░░ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄
// █▀█ ▀▄▀ █▀█ █ █▄▄ █▀█ █▄█ █▄▄ ██▄   █▄█ █▀█ █░▀█ █▄▀
// ");
//
//   Console.Write("Which band do you like to available: ");
//
//   var bandName = Console.ReadLine()!;
//
//   if (registerBands!.ContainsKey(bandName))
//   {
//     Console.Write($"Which rate for this band: ");
//
//     var rate = int.Parse(Console.ReadLine()!);
//
//     registerBands[bandName].Add(rate);
//
//     Console.WriteLine($"\nThe rate {rate} it's registered with successfully.");
//
//     Console.ReadKey();
//   }
//   else
//   {
//     Console.WriteLine($"Band {bandName} isn't registered.");
//     
//     Console.ReadKey();
//   }
// }
//
// void AverageBandRate()
// {
//   Console.Clear();
//   
//   Console.WriteLine(@"
// ▄▀█ █░█ █▀▀ █▀█ ▄▀█ █▀▀ █▀▀   █▀█ █▀▀   ▀█▀ █░█ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▀ █▀   █▀█ ▄▀█ ▀█▀ █ █▄░█ █▀▀ █▀
// █▀█ ▀▄▀ ██▄ █▀▄ █▀█ █▄█ ██▄   █▄█ █▀░   ░█░ █▀█ ██▄   █▄█ █▀█ █░▀█ █▄▀ ░ ▄█   █▀▄ █▀█ ░█░ █ █░▀█ █▄█ ▄█
// ");
//   
//   Console.Write("Which band do you like to see: ");
//
//   var bandName = Console.ReadLine()!;
//   
//   if (registerBands!.ContainsKey(bandName))
//   {
//     Console.Write($"Average band's rating: {registerBands[bandName].Average()}\n");
//
//     Console.ReadKey();
//   }
//   else
//   {
//     Console.WriteLine($"Band {bandName} isn't registered.");
//     
//     Console.ReadKey();
//   }
// }
//
// while (exit)
// {
//   Console.Clear();
//
//   Menu();
//
//   OptionsMenu(chosenOption);
// }
//
// #endregion

using MyMusics.Classes.Bands;
using MyMusics.Classes.Podcasts;

var music = new Music("One Reason", new Band("Millet"), 255, true);
var music2 = new Music("Walkin' In My Lane", new Band("Millet"), 241, false);
var music3 = new Music("Love When I Cry", new Band("Millet"), 199, true);

var album = new Album("Walkin' In My Lane", new Gender("Pop"));
album.AddMusic(music);
album.AddMusic(music2);
album.AddMusic(music3);

var band = new Band("Millet");

band.AddAlbums(album);

band.ShowDiscography();

Console.WriteLine("\n-----------------------------------------\n");

var episode1 = new Episodes(1, "Introdução à Inteligência Artificial", 3700);
episode1.AddGuests("John Smith");
episode1.AddGuests("Emily Johnson");

var episode3 = new Episodes(3, "Segurança Cibernética e Proteção de Dados", 3000);
episode3.AddGuests("David Ramirez");
episode3.AddGuests("Lisa Chen");

var episode5 = new Episodes(5, "Desenvolvimento de Aplicativos para Smartphones", 3000);
episode5.AddGuests("Robert Johnson");
episode5.AddGuests("Megan Wilson");
episode5.AddGuests("Sarah Thompson");

var episode2 = new Episodes(2, "O Futuro da Realidade Virtual", 3600);
episode2.AddGuests("Michael Anderson");
episode2.AddGuests("Sarah Thompson");

var episode4 = new Episodes(4, "Tendências em Dispositivos Móveis", 3300);
episode4.AddGuests("Mark Davis");
episode4.AddGuests("Jessica Lee");

var podcast = new Podcast("Tech Talk", "Lucas Silva");
podcast.AddEpisodes(episode4);
podcast.AddEpisodes(episode2);
podcast.AddEpisodes(episode5);
podcast.AddEpisodes(episode1);
podcast.AddEpisodes(episode3);

podcast.ShowDetails();
