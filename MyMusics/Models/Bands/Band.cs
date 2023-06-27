namespace MyMusics.Models.Bands;

public class Band
{
    public string Name { get; set; }
    private readonly List<Album> _albums = new();
    private readonly List<int> _rate;
    public double Average => _rate.Average();

    public Band(string name, List<int> rate)
    {
        Name = name;
        _rate = rate;
    }

    public void AddAlbums(Album album)
    {
        _albums.Add(album);
    }

    public void AddRate(int rate)
    {
        _rate.Add(rate);
    }

    public void ShowDiscography()
    {
        var listAlbums = string.Join(Environment.NewLine,
            _albums.Select(album => $"- {album.Name} ({album.Duration / 60} min)"));

        Console.WriteLine($"\n{Name} discography");
        Console.WriteLine($"{listAlbums}");
    }
}