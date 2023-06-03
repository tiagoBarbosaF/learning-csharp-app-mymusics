namespace MyMusics.Classes.Podcasts;

public class Episodes
{
    public int Number { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    private List<Guests> _guests = new();

    public string Resume => $"{Number} - {Title}\n" +
                            $"Duration: {Duration / 60} min\n" +
                            $"Guests:\n{string.Join(", ", _guests.Select(guest => $"{guest.Name}"))}";

    public Episodes(int number, string title, int duration)
    {
        Number = number;
        Title = title;
        Duration = duration;
    }

    public void AddGuests(string guest)
    {
        _guests.Add(new Guests(guest));
    }
}