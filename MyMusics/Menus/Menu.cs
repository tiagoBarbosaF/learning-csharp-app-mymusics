using MyMusics.Models.Bands;

namespace MyMusics.Menus;

internal abstract class Menu
{
    const string WelcomeMessage = "Welcome to My Playlist!";
    public static bool exit = true;
    public static int ChosenOption { get; set; }

    private static void ShowWelcomeMessage()
    {
        Console.WriteLine(@"
█▀▄▀█ █▄█   █▀▄▀█ █░█ █▀ █ █▀▀ █▀
█░▀░█ ░█░   █░▀░█ █▄█ ▄█ █ █▄▄ ▄█");
        Console.WriteLine();
        Console.WriteLine(WelcomeMessage);
    }

    public static void MenuOptions()
    {
        ShowWelcomeMessage();
        Console.WriteLine("\n- Enter 1 to register a band");
        Console.WriteLine("- Enter 2 to list all bands");
        Console.WriteLine("- Enter 3 to available a band");
        Console.WriteLine("- Enter 4 to show an average of a band");
        Console.WriteLine("- Enter 5 to register an album");
        Console.WriteLine("- Enter 6 to show band details");
        Console.WriteLine("- Enter 0 to exit");

        Console.Write("\nEnter your option: ");
        ChosenOption = int.Parse(Console.ReadLine()!);
    }

    protected virtual void Execute(Dictionary<string, Band> registerBands)
    {
        Console.Clear();
    }

    public static void OptionsMenu(int chosenOption, Dictionary<string, Band> registerBands)
    {
        var dictionaryMenus = new Dictionary<int, Menu>
        {
            {1, new MenuRegisterBand()},
            {2, new MenuListBands()},
            {3, new MenuAvailableBand()},
            {4, new MenuAverageBandRate()},
            {5, new MenuRegisterAlbum()},
            {6, new MenuShowBandDetails()},
            {0, new MenuExit()}
        };

        if (dictionaryMenus!.ContainsKey(ChosenOption))
        {
            var option = dictionaryMenus[ChosenOption];
            option.Execute(registerBands);
        }
    }
}