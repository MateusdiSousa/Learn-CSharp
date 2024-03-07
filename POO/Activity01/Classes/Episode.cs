using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity01.Classes
{
    public class Episode
    {
        public int Duration { get; set; }

        public int Order { get; set; }

        public string Resume { get; set; }

        public string Title { get; set; }

        public Episode(string title, int duration, int order, string resume = " ")
        {
            this.Duration = duration;
            this.Title = title;
            this.Resume = resume;
            this.Order = order;
        }

        public List<Inveted> inveteds = new List<Inveted>();

        public void AddInveted(Inveted inveted)
        {
            inveteds.Add(inveted);
        }
    }
}