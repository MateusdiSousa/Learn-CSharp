namespace POO
{
    public class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public bool Avaliable { get; set; }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public Music(string name, string artist)
        {
            this.Artist = artist;
            this.Name = name;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Name of the song: {this.Name}");
            System.Console.WriteLine($"Name of the artist: {this.Artist}");
            System.Console.WriteLine($"Duration: {Duration / 60}:{Duration % 60}");
            System.Console.WriteLine(Description);
            if (this.Avaliable)
            {
                System.Console.WriteLine("Listen now on platform\n");
            }
            else
            {
                System.Console.WriteLine("This song is not avaliable\n");
            }
        }
    }
}