using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class Position
    {
        public int number { get; set; }
        public Position next { get; set; }
        public List<Player> list { get; set; } = new List<Player>();

        public Position()
        {
        }
        public Position(int num)
        {
            number = num;
            next = null;
        }
        public void AddPlayer(Player p)
        {
            list.Add(p);
        }
        public void RemovePlayer(Player p)
        {
            list.Remove(p);
        }
        public virtual void Show()
        {
            Console.WriteLine(number);
        }
    }
}
