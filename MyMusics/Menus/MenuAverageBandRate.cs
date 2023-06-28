using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuAverageBandRate : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
▄▀█ █░█ █▀▀ █▀█ ▄▀█ █▀▀ █▀▀   █▀█ █▀▀   ▀█▀ █░█ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▀ █▀   █▀█ ▄▀█ ▀█▀ █ █▄░█ █▀▀ █▀
█▀█ ▀▄▀ ██▄ █▀▄ █▀█ █▄█ ██▄   █▄█ █▀░   ░█░ █▀█ ██▄   █▄█ █▀█ █░▀█ █▄▀ ░ ▄█   █▀▄ █▀█ ░█░ █ █░▀█ █▄█ ▄█
");

        Console.Write("Which band do you like to see: ");

        var bandName = Console.ReadLine()!;

        if (registerBands!.ContainsKey(bandName))
        {
            var band = registerBands[bandName];

            Console.Write($"Average band's rating: {band.Average}\n");

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"Band {bandName} isn't registered.");

            Console.ReadKey();
        }
    }
}