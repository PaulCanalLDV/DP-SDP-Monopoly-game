using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Player a = new Player("test");
            Player b = new Player("test2");
            Players l = new Players();
            l.AddPlayer(a);
            l.AddPlayer(b);
            Console.WriteLine(l[l.list.IndexOf(l.head())+1].Name);
            Console.WriteLine(l[a].Show());
            //Game g = new Game();
            Console.ReadKey();
        }
    }
}
