namespace MyMusics.Models.Bands;

public class Music
{
    public string Name { get; }
    private Band Artist { get; }
    public int Duration { get; }
    private bool Available { get; }

    private string ShortDescription => $"The Music {Name} is from artist {Artist}";

    
    public Music(string name, Band artist, int duration, bool available)
    {
        Name = name;
        Artist = artist;
        Duration = duration;
        Available = available;
    }

    public override string ToString()
    {
        var textAvailable = Available ? "Available plan." : "Acquire the plus plan.";

        return $"\n- Music -\n" +
               $"Name: {Name}\n" +
               $"Artist: {Artist.Name}\n" +
               $"Duration: {Duration}\n" +
               $"Available: {textAvailable}\n" +
               $"Short Description: {ShortDescription}";
    }
}