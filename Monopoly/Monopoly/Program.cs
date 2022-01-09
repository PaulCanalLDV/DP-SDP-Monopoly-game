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
            /*
            Player a = new Player("test");
            Player b = new Player("test2");
            Players l = new Players();
            l.AddPlayer(a);
            l.AddPlayer(b);
            Console.WriteLine(l[l[l.head()]+1].Name);
            a.Show();
            l[0].Show();
            Console.WriteLine(a == l[0]);
            */
            Game g = new Game();
            Console.ReadKey();
        }
    }
}
