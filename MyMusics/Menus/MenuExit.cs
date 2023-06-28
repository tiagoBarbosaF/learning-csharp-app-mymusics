using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal class MenuExit : Menu
{
    protected override void Execute(Dictionary<string, Band> registerBands)
    {
        exit = false;
        Console.WriteLine("\nSee you later!");
    }
}