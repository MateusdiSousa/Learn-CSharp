using POO;

public class Album
{
    public string Name { get; set; } = "";

    private List<Music> musics = new List<Music>();

    public int TotalDuration { get; set; }

    public void AddMusic(Music music)
    {
        musics.Add(music);
        TotalDuration += music.Duration;
    }

    public void ShowMusics()
    {
        System.Console.WriteLine("================================\n");

        System.Console.WriteLine($"{Name}".ToUpper());
        System.Console.WriteLine($"Duration: {TotalDuration/60}:{TotalDuration%60}\n");

        foreach (Music music in musics)
        {
            music.ShowInfo();
        }
        System.Console.WriteLine("================================");
    }
}