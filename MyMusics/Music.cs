namespace MyMusics;

public class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }

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
               $"Available: {textAvailable}";
    }
}