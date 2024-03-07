using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity01.Classes
{
    public class Podcast
    {
        public string Name { get; }

        public string Host { get; }

        public List<Episode> AllEpisodios = [];

        public Podcast(string name, string host)
        {
            this.Name = name;
            this.Host = host;
        }

        public void AddEpisode(Episode episode)
        {
            AllEpisodios.Add(episode);
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Welcome to the {Name} Podcast");
            System.Console.WriteLine("Listen all the episodes: \n");
            List<Episode> ordenedList = AllEpisodios.OrderBy(x => x.Order).ToList();
            foreach (Episode episode in ordenedList)
            {
                System.Console.WriteLine($"Title: {episode.Title}");
                System.Console.WriteLine($"Duration: {episode.Duration / 60}: {episode.Duration%60}");
                System.Console.WriteLine($"Resume: {episode.Resume}");
                System.Console.WriteLine($"Inveteds: ");
                foreach (Inveted inveted in episode.inveteds)
                {
                    System.Console.WriteLine($"     {inveted.Name}");
                }
                System.Console.WriteLine("\n===========================================\n");
            }
        }
    }
}