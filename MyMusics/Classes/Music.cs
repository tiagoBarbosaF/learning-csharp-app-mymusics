namespace MyMusics.Classes;

public class Music
{
    public string Name { get; }
    private string Artist { get; }
    public int Duration { get; }
    private bool Available { get; }

    private string ShortDescription => $"The Music {Name} is from artist {Artist}";

    
    public Music(string name, string artist, int duration, bool available)
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
               $"Artist: {Artist}\n" +
               $"Duration: {Duration}\n" +
               $"Available: {textAvailable}\n" +
               $"Short Description: {ShortDescription}";
    }
}