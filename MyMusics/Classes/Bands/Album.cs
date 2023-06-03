namespace MyMusics.Classes.Bands;

public class Album
{
    public string Name { get; set; }
    private readonly List<Music> _musics = new();
    private Gender Gender { get; set; }
    public int Duration => _musics.Sum(music => music.Duration);

    public Album(string name, Gender gender)
    {
        Name = name;
        Gender = gender;
    }

    public override string ToString()
    {
        var musicList = string.Join(Environment.NewLine, _musics.Select(music => $"- {music.Name}"));

        return $"\n- Album -\n" +
               $"Name: {Name}\n" +
               $"Gender: {Gender.Name}\n" +
               $"Duration: {Duration / 60} minutes\n" +
               $"Musics:\n" +
               $"{musicList}";
    }

    public void AddMusic(Music music)
    {
        _musics.Add(music);
    }
}