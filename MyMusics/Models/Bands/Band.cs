namespace MyMusics.Models.Bands;

internal class Band
{
    public string Name { get; }
    private readonly List<Album> _albums = new();
    private readonly List<Appraisal> _rate;

    public double Average => _rate.Count == 0 ? 0 : _rate.Average(appraisal => appraisal.Rate);

    public Band(string name, List<Appraisal> rate)
    {
        Name = name;
        _rate = rate;
    }

    public void AddAlbums(Album album)
    {
        _albums.Add(album);
    }

    public void AddRate(Appraisal rate)
    {
        _rate.Add(rate);
    }

    public void ShowDiscography()
    {
        var listAlbums = string.Join(Environment.NewLine,
            _albums.Select(album => $"- {album.Name} ({album.Duration / 60} min)"));

        Console.WriteLine($"\n{Name} discography\n" +
                          $"{listAlbums}\n\n" +
                          $"Total Albums: {_albums.Count}");
    }
}