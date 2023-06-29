using MyMusics.Models.Interfaces;

namespace MyMusics.Models.Bands;

internal class Album : IRate
{
    public string Name { get; }
    public readonly List<Music> Musics = new();
    private Gender Gender { get; }
    public int Duration => Musics.Sum(music => music.Duration);
    private readonly List<Appraisal> _rate = new();
    public double Average => _rate.Count == 0 ? 0 : _rate.Average(appraisal => appraisal.Rate);

    public Album(string name, Gender gender)
    {
        Name = name;
        Gender = gender;
    }

    public override string ToString()
    {
        var musicList = string.Join(Environment.NewLine, Musics.Select(music => $"- {music.Name}"));

        return $"\n- Album -\n" +
               $"Name: {Name}\n" +
               $"Gender: {Gender.Name}\n" +
               $"Duration: {Duration / 60} minutes\n" +
               $"Musics:\n" +
               $"{musicList}";
    }

    public void AddMusic(Music music) => Musics.Add(music);

    public void AddRate(Appraisal rate) => _rate.Add(rate);

    public void ShowMusics()
    {
        Console.WriteLine("\nMusics:");

        foreach (var music in Musics)
            Console.WriteLine($"=> {music.Name}\n" +
                              $"    - Rate: {music.Average}\n" +
                              $"    - Duration: {music.Duration / 60} min");
        Console.WriteLine($"\nTotal Albums: {Musics.Count}");
    }
}