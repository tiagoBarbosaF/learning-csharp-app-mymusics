namespace MyMusics.Classes;

public class Band
{
    public string Name { get; set; }
    private readonly List<Album> _albums = new();

    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbums(Album album)
    {
        _albums.Add(album);
    }

    public void ShowDiscography()
    {
        var listAlbums = string.Join(Environment.NewLine,
            _albums.Select(album => $"- {album.Name} ({album.Duration / 60} min)"));

        Console.WriteLine($"\n{Name} discography");
        Console.WriteLine($"{listAlbums}");
    }
}