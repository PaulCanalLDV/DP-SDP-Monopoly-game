using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Player player1 = new Player("Paul");
            while (i < 100)
            {
                if (player1.NbDouble == -1) // en prison
                {
                    Console.WriteLine("Joueur 1 est en prison, veuillez lancer le dé.");
                    int b = player1.RollTheDice();
                    if (player1.NbDouble == -2) // il a réussi a faire un double, il sort
                    {
                        player1.Position += b;
                        player1.NbDouble = 3;
                    }
                }
                else if (player1.NbDouble == 3)
                {
                    int a = player1.RollTheDice();
                    player1.Position += a;
                    Console.WriteLine("Joueur 1 a lancé le dé et a obtenu : " + a);
                    Console.WriteLine("Joueur 1 va jusqu'à la case : " + player1.Position);
                    if (player1.NbDouble == 2)// il a fait un double
                    {
                        int c = player1.RollTheDice();
                        player1.Position += c;
                        Console.WriteLine("Joueur 1 a lancé le dé et a obtenu : " + c);
                        Console.WriteLine("Joueur 1 va jusqu'à la case : " + player1.Position);
                    }
                    if (player1.NbDouble == 1) // il refait un double
                    {
                        int d = player1.RollTheDice();
                        player1.Position += d;
                        Console.WriteLine("Joueur 1 a lancé le dé et a obtenu : " + d);
                        Console.WriteLine("Joueur 1 va jusqu'à la case : " + player1.Position);
                    }
                    if (player1.NbDouble == 0)
                    {
                        player1.Position = 10; // PRISON FILS DE PUTE
                        player1.NbDouble = -1;
                    }
                    if (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        i = i + 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
