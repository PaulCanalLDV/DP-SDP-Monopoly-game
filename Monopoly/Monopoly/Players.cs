using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Players : Aggregate
    {
        public List<Player> list = new List<Player>();

        public Players() { }

        public void AddPlayer(Player player)
        {
            list.Add(player);
        }
        public PlayerIterator CreateIterator()
        {
            return new PlayerIterator(this);
        }

        public Player head()
        {
            return list.First();
        }
        
        public int length()
        {
            return list.Count;
        }

        public Player this[int index]
        {
            get
            {
                return list[index];
            }
        }
        public int this[Player p]
        {
            get
            {
                return list.IndexOf(p);
            }
        }

        public void Show()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Player n°" + (i + 1));
                list[i].Show();
            }
        }
    }
}
