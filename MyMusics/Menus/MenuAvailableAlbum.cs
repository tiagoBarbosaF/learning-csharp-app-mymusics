using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuAvailableAlbum : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █ █░░ ▄▀█ █▄▄ █░░ █▀▀   ▄▀█ █░░ █▄▄ █░█ █▀▄▀█
█▀█ ▀▄▀ █▀█ █ █▄▄ █▀█ █▄█ █▄▄ ██▄   █▀█ █▄▄ █▄█ █▄█ █░▀░█
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

                Console.Write($"Which rate for this album ({albumTitle}): ");

                var rate = Appraisal.Parse(Console.ReadLine()!);

                album.AddRate(rate);

                Console.WriteLine($"\nThe rate {rate.Rate} it's registered for the album {albumTitle} with successfully.");

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