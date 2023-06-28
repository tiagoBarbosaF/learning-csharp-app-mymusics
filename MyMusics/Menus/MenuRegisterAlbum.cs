using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuRegisterAlbum: Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀▀ █▀█   ▄▀█ █░░ █▄▄ █░█ █▀▄▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ ██▄ █▀▄   █▀█ █▄▄ █▄█ █▄█ █░▀░█
");

        Console.Write("Which band do you like to register an album: ");

        var bandName = Console.ReadLine()!;

        if (registerBands!.ContainsKey(bandName))
        {
            Console.Write("\nEnter the album title: ");

            var albumTitle = Console.ReadLine()!;

            Console.WriteLine("\nEnter the gender of album: ");

            var albumGender = Console.ReadLine()!;

            var band = registerBands[bandName];

            band.AddAlbums(new Album(albumTitle, new Gender(albumGender)));

            Console.WriteLine($"\nAlbum {albumTitle} is record for the band {bandName}");

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"Band {bandName} isn't registered.");

            Console.ReadKey();
        }
    }
}