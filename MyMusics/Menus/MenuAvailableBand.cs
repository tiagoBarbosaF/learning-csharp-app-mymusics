using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuAvailableBand : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █ █░░ ▄▀█ █▄▄ █░░ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄
█▀█ ▀▄▀ █▀█ █ █▄▄ █▀█ █▄█ █▄▄ ██▄   █▄█ █▀█ █░▀█ █▄▀
");

        Console.Write("Which band do you like to available: ");

        var bandName = Console.ReadLine()!;

        if (registerBands!.ContainsKey(bandName))
        {
            var band = registerBands[bandName];

            Console.Write($"Which rate for this band: ");

            var rate = Appraisal.Parse(Console.ReadLine()!);

            band.AddRate(rate);

            Console.WriteLine($"\nThe rate {rate.Rate} it's registered with successfully.");

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"Band {bandName} isn't registered.");

            Console.ReadKey();
        }
    }
}