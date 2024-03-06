namespace POO
{
    class Program
    {
        static void Main(String[] args)
        {
            Band queen = new Band("Queen");

            Music bohemianQueen = new Music("Bohemian Rhapsody", queen);
            bohemianQueen.Duration = 57;
            bohemianQueen.Avaliable = true;
            bohemianQueen.Description = "The song Killet Queen belong to the band Queen";
            
            Music music2 = new Music("Love of my life", queen);
            music2.Duration = 327;
            music2.Avaliable = false;
            music2.Description = "The song Killet Queen belong to the band Queen";
                        
            Album queenAlbum = new Album();

            queenAlbum.Name = "A night at the opera";

            queenAlbum.AddMusic(bohemianQueen);
            queenAlbum.AddMusic(music2);

            queen.addAlbum(queenAlbum);

            queen.showDiscograph();
        }
    }
}