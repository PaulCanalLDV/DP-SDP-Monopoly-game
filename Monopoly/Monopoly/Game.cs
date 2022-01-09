using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Game
    {
        private Players list_of_players;
        private Board_game board_game;

        public Game()
        {
            list_of_players = new Players();
            Console.WriteLine("Veuillez rentrer le nom du 1er joueur : ");
            list_of_players.AddPlayer(new Player(Console.ReadLine()));
            Console.WriteLine("Veuillez rentrer le nom du 2ème joueur : ");
            string s = Console.ReadLine();
            bool b = true;
            while (b)
            {

                list_of_players.AddPlayer(new Player(s));
                Console.WriteLine("Veuillez rentrer le nom d'un joueur à ajouter (tapez 'stop' pour arrêter d'ajouter des joueurs) : ");
                s = Console.ReadLine();
                if (s == "stop")
                {
                    b = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine(list_of_players.length());
            list_of_players.Show();
            board_game = new Board_game();
            board_game.Show();
        }
        public void Reset()
        {

        }
    }
}
