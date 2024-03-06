public class Band
{
    public string Name { get;  }
    private List<Album> albums = new List<Album>();
    public Band(string nome) {
        Name = nome;
    }

    public void addAlbum(Album album){
        albums.Add(album);
    }

    public void showDiscograph(){
        System.Console.WriteLine($"Discograph of {Name}");
        foreach (Album album in albums)
        {
            System.Console.WriteLine($"Album: {album.Name} ({album.TotalDuration/60}:{album.TotalDuration%60})");
        }
    }
}