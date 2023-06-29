using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuAvailableMusic : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);
        
        Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █ █░░ ▄▀█ █▄▄ █░░ █▀▀   █▀▄▀█ █░█ █▀ █ █▀▀
█▀█ ▀▄▀ █▀█ █ █▄▄ █▀█ █▄█ █▄▄ ██▄   █░▀░█ █▄█ ▄█ █ █▄▄
");

        Console.Write("Which band do you like to available: ");

        var bandName = Console.ReadLine()!;

        if (registerBands!.ContainsKey(bandName))
        {
            var band = registerBands[bandName];

            Console.WriteLine("Choose an album to rate:");
            band.ShowDiscography();

            Console.Write("\nEnter the album title: ");

            var albumTitle = Console.ReadLine()!;

            if (band.Albums.Any(album => album.Name.Equals(albumTitle)))
            {
                var album = band.Albums.First(album => album.Name.Equals(albumTitle));

                Console.Write($"\nWhich music for this album ({albumTitle} do you like to rate): ");

                var chosenMusic = Console.ReadLine()!;

                var music = album.Musics.First(music => music.Name.Equals(chosenMusic));

                Console.Write($"Rate music ({music.Name}): ");

                var rate = Appraisal.Parse(Console.ReadLine()!);

                music.AddRate(rate);

                Console.WriteLine($"\nThe rate {rate.Rate} it's registered for the music {chosenMusic} with successfully.");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Album {albumTitle} isn't registered.");

                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine($"Band {bandName} isn't registered.");

            Console.ReadKey();
        }
    }
}