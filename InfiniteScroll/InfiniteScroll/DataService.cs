using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteScroll
{
    public class DataService
    {
        private readonly List<Player> players = new List<Player>
        {
            new Player
            {
                Name="C.Ronaldo",
                Image="ronaldo",
                Club="Juventus"
            },
             new Player
            {
                Name="Messi",
                Image="messi",
                Club="Barcelona"

            },
              new Player
            {
                Name="Modric",
                Image="modric",
                Club="Real Madrid"
            },
               new Player
            {
                Name="Mesut Özil",
                Image="mesut",
                Club="Arsenal"
            },
                new Player
            {
                Name="Pogba",
                Image="pogba",
                Club="Manchester United"
            },
                 new Player
            {
                Name="Bale",
                Image="bale",
                Club="Real Madrid"
            },
                  new Player
            {
                Name="Suarez",
                Image="suarez",
                Club="Barcelona"
            },
                   new Player
            {
                Name="Volkan Demirel",
                Image="volkan",
                Club="Fenerbahçe"
            },
                    new Player
            {
                Name="Alex",
                Image="alex",
                Club="Fenerbahçe"
            },
                     new Player
            {
                Name="Neymar",
                Image="neymar",
                Club="PSG"
            },
                     new Player
            {
                Name="Mbappe",
                Image="mbappe",
                Club="PSG"
            },
                     new Player
            {
                Name="Dele Alli",
                Image="alli",
                Club="Tottenham"
            },new Player
            {
                Name="C.Ronaldo",
                Image="ronaldo",
                Club="Juventus"
            },
             new Player
            {
                Name="Messi",
                Image="messi",
                Club="Barcelona"

            },
              new Player
            {
                Name="Modric",
                Image="modric",
                Club="Real Madrid"
            },
               new Player
            {
                Name="Mesut Özil",
                Image="mesut",
                Club="Arsenal"
            },
                new Player
            {
                Name="Pogba",
                Image="pogba",
                Club="Manchester United"
            },
                 new Player
            {
                Name="Bale",
                Image="bale",
                Club="Real Madrid"
            },
                  new Player
            {
                Name="Suarez",
                Image="suarez",
                Club="Barcelona"
            },
                   new Player
            {
                Name="Volkan Demirel",
                Image="volkan",
                Club="Fenerbahçe"
            },
                    new Player
            {
                Name="Alex",
                Image="alex",
                Club="Fenerbahçe"
            },
                     new Player
            {
                Name="Neymar",
                Image="neymar",
                Club="PSG"
            },
                     new Player
            {
                Name="Mbappe",
                Image="mbappe",
                Club="PSG"
            },
                     new Player
            {
                Name="Dele Alli",
                Image="alli",
                Club="Tottenham"
            },new Player
            {
                Name="C.Ronaldo",
                Image="ronaldo",
                Club="Juventus"
            },
             new Player
            {
                Name="Messi",
                Image="messi",
                Club="Barcelona"

            },
              new Player
            {
                Name="Modric",
                Image="modric",
                Club="Real Madrid"
            },
               new Player
            {
                Name="Mesut Özil",
                Image="mesut",
                Club="Arsenal"
            },
                new Player
            {
                Name="Pogba",
                Image="pogba",
                Club="Manchester United"
            },
                 new Player
            {
                Name="Bale",
                Image="bale",
                Club="Real Madrid"
            },
                  new Player
            {
                Name="Suarez",
                Image="suarez",
                Club="Barcelona"
            },
                   new Player
            {
                Name="Volkan Demirel",
                Image="volkan",
                Club="Fenerbahçe"
            },
                    new Player
            {
                Name="Alex",
                Image="alex",
                Club="Fenerbahçe"
            },
                     new Player
            {
                Name="Neymar",
                Image="neymar",
                Club="PSG"
            },
                     new Player
            {
                Name="Mbappe",
                Image="mbappe",
                Club="PSG"
            },
                     new Player
            {
                Name="Dele Alli",
                Image="alli",
                Club="Tottenham"
            },new Player
            {
                Name="C.Ronaldo",
                Image="ronaldo",
                Club="Juventus"
            },
             new Player
            {
                Name="Messi",
                Image="messi",
                Club="Barcelona"

            },
              new Player
            {
                Name="Modric",
                Image="modric",
                Club="Real Madrid"
            },
               new Player
            {
                Name="Mesut Özil",
                Image="mesut",
                Club="Arsenal"
            },
                new Player
            {
                Name="Pogba",
                Image="pogba",
                Club="Manchester United"
            },
                 new Player
            {
                Name="Bale",
                Image="bale",
                Club="Real Madrid"
            },
                  new Player
            {
                Name="Suarez",
                Image="suarez",
                Club="Barcelona"
            },
                   new Player
            {
                Name="Volkan Demirel",
                Image="volkan",
                Club="Fenerbahçe"
            },
                    new Player
            {
                Name="Alex",
                Image="alex",
                Club="Fenerbahçe"
            },
                     new Player
            {
                Name="Neymar",
                Image="neymar",
                Club="PSG"
            },
                     new Player
            {
                Name="Mbappe",
                Image="mbappe",
                Club="PSG"
            },
                     new Player
            {
                Name="Dele Alli",
                Image="alli",
                Club="Tottenham"
            }

        };

        public async Task<List<Player>> GetItemAsync(int pageIndex,int pagesize)
        {
            await Task.Delay(2000);
            return players.Skip(pageIndex * pagesize).Take(pagesize).ToList();
        }
        public class Player
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Club { get; set; }
        }
    }
}
