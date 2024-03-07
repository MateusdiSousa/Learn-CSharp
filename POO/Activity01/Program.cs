using Activity01.Classes;

namespace POO
{
    class Program
    {
        static void Main(String[] args)
        {
            // Band queen = new Band("Queen");

            // Music bohemianQueen = new Music("Bohemian Rhapsody", queen);
            // bohemianQueen.Duration = 57;
            // bohemianQueen.Avaliable = true;
            // bohemianQueen.Description = "The song Killet Queen belong to the band Queen";
            
            // Music music2 = new Music("Love of my life", queen);
            // music2.Duration = 327;
            // music2.Avaliable = false;
            // music2.Description = "The song Killet Queen belong to the band Queen";
                        
            // Album queenAlbum = new Album();

            // queenAlbum.Name = "A night at the opera";

            // queenAlbum.AddMusic(bohemianQueen);
            // queenAlbum.AddMusic(music2);

            // queen.addAlbum(queenAlbum);

            // queen.showDiscograph();

            Podcast podpah = new Podcast("PodPah","Sportify");

            Inveted igor = new Inveted("Igor 3K");
            Inveted monark = new Inveted("Monark");

            Episode ep1 = new Episode("Onde tudo começou",75,1,"História do podpah");

            ep1.AddInveted(igor);
            ep1.AddInveted(monark);

            Episode ep3 = new Episode("Onde tudo começou pt 3", 45,3,"Parte final da hostória do podpah");
            ep3.AddInveted(igor);
            Episode ep2 = new Episode("Onde tudo começou pt 2", 45,2,"Desenvolvimento da hostória do podpah");
            ep2.AddInveted(monark);

            podpah.AddEpisode(ep3);
            podpah.AddEpisode(ep1);
            podpah.AddEpisode(ep2);

            podpah.ShowDetails();

        }
    }
}