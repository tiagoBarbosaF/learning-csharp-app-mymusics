using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuListBands : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ █▀   █░░ █ █▀ ▀█▀
█▄█ █▀█ █░▀█ █▄▀ ▄█   █▄▄ █ ▄█ ░█░
");

        Console.WriteLine();

        foreach (var band in registerBands!)
        {
            Console.WriteLine($"- {band.Key}");
            Console.WriteLine($"  Rate: {band.Value.Average:F}\n");
        }

        Console.ReadKey();
    }
}