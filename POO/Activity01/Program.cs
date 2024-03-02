namespace POO
{
    class Program
    {
        static void Main(String[] args)
        {
            Music bohemianQueen = new Music("Bohemian Rhapsody", "Queen");
            bohemianQueen.Duration = 257;
            bohemianQueen.Avaliable = true;
            bohemianQueen.Description = "The song Killet Queen belong to the band Queen";
            
            Music music2 = new Music("Love of my life", "Queen");
            music2.Duration = 327;
            music2.Avaliable = false;
            music2.Description = "The song Killet Queen belong to the band Queen";
                        
            Album queenAlbum = new Album();

            queenAlbum.Name = "A night at the opera";

            queenAlbum.AddMusic(bohemianQueen);
            queenAlbum.AddMusic(music2);

            queenAlbum.ShowMusics();
        }
    }
}