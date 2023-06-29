using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuShowBandDetails : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        base.Execute(registerBands);

        Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄   █▀▄ █▀▀ ▀█▀ ▄▀█ █ █░░ █▀
█▄█ █▀█ █░▀█ █▄▀   █▄▀ ██▄ ░█░ █▀█ █ █▄▄ ▄█
");

        Console.Write("\nEnter band name: ");

        var bandName = Console.ReadLine()!;

        if (registerBands.ContainsKey(bandName))
        {
            var rateband = registerBands[bandName].Average;

            var band = registerBands[bandName];

            Console.Write($"\n== Band ==\n" +
                          $" Name: {bandName} | Rate: {rateband:F}");
            band.ShowDiscography();

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"Band {bandName} isn't registered.");

            Console.ReadKey();
        }
    }
}