namespace MyMusics.Models.Podcasts;

internal class Podcast
{
    public string Host { get; set; }
    public string Name { get; set; }

    private readonly List<Episodes> _episodes = new();
    public int TotalEpisodes => _episodes.Count;

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }


    public void AddEpisodes(Episodes episode)
    {
        _episodes.Add(episode);
    }

    public void ShowDetails()
    {
        var listEpisodes = string.Join(Environment.NewLine,
            _episodes.OrderBy(episode => episode.Number).Select(episode =>
                $"{episode.Resume}\n"));

        Console.WriteLine($"\n- Podcast -\n" +
                          $"Name: {Name} - Host: {Host}\n" +
                          $"Episodes:\n" +
                          $"{listEpisodes}\n" +
                          $"Total Episodes: {TotalEpisodes}");
    }
}