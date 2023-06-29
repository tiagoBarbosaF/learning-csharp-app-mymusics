using MyMusics.Models.Interfaces;

namespace MyMusics.Models.Bands;

internal class Band : IRate
{
    public string Name { get; }
    public readonly List<Album> Albums = new();
    private readonly List<Appraisal> _rate;

    public double Average => _rate.Count == 0 ? 0 : _rate.Average(appraisal => appraisal.Rate);

    public Band(string name, List<Appraisal> rate)
    {
        Name = name;
        _rate = rate;
    }

    public void AddAlbums(Album album) => Albums.Add(album);

    public void AddRate(Appraisal rate) => _rate.Add(rate);

    public void ShowDiscography()
    {
        Console.WriteLine("\n\nDiscography:");

        foreach (var album in Albums)
        {
            Console.WriteLine("== Album ==");
            Console.WriteLine($"  {album.Name} | Rate: {album.Average} | Duration: {album.Duration / 60} min");
            Console.WriteLine("\n== Musics ==");
            foreach (var music in album.Musics)
                Console.WriteLine($"- {music.Name} | Rate: {music.Average} | Duration: {music.Duration / 60} min");
            Console.WriteLine("----------------------------------------------");
        }

        Console.WriteLine($"\nTotal Albums: {Albums.Count}");
    }
}