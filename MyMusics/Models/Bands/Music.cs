using MyMusics.Models.Interfaces;

namespace MyMusics.Models.Bands;

internal class Music : IRate
{
    public string Name { get; }
    private Band Artist { get; }
    public int Duration { get; }
    private bool Available { get; }
    private readonly List<Appraisal> _rate = new();
    public double Average => _rate.Count == 0 ? 0 : _rate.Average(appraisal => appraisal.Rate);

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

    public void AddRate(Appraisal rate) => _rate.Add(rate);
}