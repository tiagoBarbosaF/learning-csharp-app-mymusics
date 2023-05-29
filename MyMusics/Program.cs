const string welcomeMessage = "Welcome to My Playlist!";
var exit = true;
var chosenOption = "";
var bandsList = new List<string>
{
  "Millet",
  "Beatles",
  "Neo Japonism",
  "Doul"
};

void ShowWelcomeMessage()
{
  Console.WriteLine(@"
█▀▄▀█ █▄█   █▀▄▀█ █░█ █▀ █ █▀▀ █▀
█░▀░█ ░█░   █░▀░█ █▄█ ▄█ █ █▄▄ ▄█");
  Console.WriteLine();
  Console.WriteLine(welcomeMessage);
}

void Menu()
{
  ShowWelcomeMessage();
  Console.WriteLine("\n- Enter 1 to register a band");
  Console.WriteLine("- Enter 2 to list all bands");
  Console.WriteLine("- Enter 3 to available a band");
  Console.WriteLine("- Enter 4 to show an average of a band");
  Console.WriteLine("- Enter 0 to exit");

  Console.Write("\nEnter your option: ");
  chosenOption = Console.ReadLine();
}

void OptionsMenu(string chosenOption)
{
  switch (chosenOption)
  {
    case "1":
      RegisterBand();
      break;
    case "2":
      ListBands();
      break;
    case "3":
      Console.WriteLine("Option 3");
      break;
    case "4":
      Console.WriteLine("Option 4");
      break;
    case "0":
      exit = false;
      Console.WriteLine("\nSee you later!");
      break;
    default:
      Console.WriteLine("\nChosen Option not available!");
      break;
  }
}

void RegisterBand()
{
  Console.Clear();

  Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀▀ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄
█▀▄ ██▄ █▄█ █ ▄█ ░█░ ██▄ █▀▄   █▄█ █▀█ █░▀█ █▄▀
");

  Console.Write($"\nEnter the band name for register: ");

  var bandName = Console.ReadLine()!;

  Console.WriteLine($"\nThe band {bandName} it's register successfully!");

  bandsList.Add(bandName);

  Console.ReadKey();
}

void ListBands()
{
  Console.Clear();

  Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ █▀   █░░ █ █▀ ▀█▀
█▄█ █▀█ █░▀█ █▄▀ ▄█   █▄▄ █ ▄█ ░█░
");

  Console.WriteLine();

  foreach (var band in bandsList!)
  {
    Console.WriteLine($"\t- {band}");
  }

  Console.ReadKey();
}

while (exit)
{
  Console.Clear();

  Menu();

  OptionsMenu(chosenOption);
}