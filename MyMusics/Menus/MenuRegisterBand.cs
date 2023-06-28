using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuRegisterBand : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀▀ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄
█▀▄ ██▄ █▄█ █ ▄█ ░█░ ██▄ █▀▄   █▄█ █▀█ █░▀█ █▄▀
");

        Console.Write($"\nEnter the band name for register: ");

        var bandName = Console.ReadLine()!;

        Console.WriteLine($"\nThe band {bandName} it's register successfully!");

        var band = new Band(bandName, new List<Appraisal>());

        registerBands.Add(bandName, band);

        Console.ReadKey();
    }
}