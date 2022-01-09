using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        private Players list_of_players;
        private Board_game board_game;
        private PlayerIterator pIter;

        public Game()
        {
            board_game = new Board_game();
            //board_game.Show();
            list_of_players = new Players();
            Console.WriteLine("Please enter the name of the first player : ");
            list_of_players.AddPlayer(new Player(Console.ReadLine(), board_game.Head));
            Console.WriteLine("Please enter the name of the second player : ");
            string s = Console.ReadLine();
            bool b = true;
            while (b)
            {
                list_of_players.AddPlayer(new Player(s, board_game.Head));
                Console.WriteLine("Please enter the name of a player to add (enter 'stop' to stop adding players) :");
                s = Console.ReadLine();
                if (s == "stop")
                {
                    b = false;
                }
            }
            Console.WriteLine();
            list_of_players.Show();
            Console.WriteLine();
        }
        public void Reset()
        {

        }
        public void Launch(int number_of_turns)
        {
            pIter = new PlayerIterator(list_of_players);
            for(int i = 0; i < number_of_turns; i++)
            {
                Console.WriteLine("Turn n°" + (i + 1));
                Turn();
                Display();
                Console.WriteLine();
            }
        }
        public void Turn()
        {
            //Console.WriteLine(pIter);
            for(int i = 0; i < list_of_players.length(); i++)
            {
                Player currentPlayer = pIter.Next();
                currentPlayer.Show();
                int d;
                if (currentPlayer.Jailed == 0)
                {
                    currentPlayer.Position.RemovePlayer(currentPlayer);
                    bool b = true;
                    do
                    {
                        Console.WriteLine("Roll the dice! (hit the enter key)");
                        Console.ReadKey();
                        d = currentPlayer.RollTheDice();
                        switch (currentPlayer.NbDouble)
                        {
                            case 3:
                                currentPlayer.Position = board_game.MoveForward(d, currentPlayer.Position);
                                b = false;
                                break;

                            case 2:
                            case 1:
                                currentPlayer.Position = board_game.MoveForward(d, currentPlayer.Position);
                                break;

                            case 0:
                                Console.WriteLine("Go to jail!");
                                currentPlayer.Position = board_game.Jail();
                                currentPlayer.NbDouble = 3;
                                currentPlayer.Jailed = 3;
                                b = false;
                                break;
                        }
                        currentPlayer.Show();
                        if (currentPlayer.Position == board_game.GoToJail())
                        {
                            Console.WriteLine("Go to jail!");
                            currentPlayer.Position = board_game.Jail();
                            currentPlayer.NbDouble = 3;
                            currentPlayer.Jailed = 3;
                            b = false;
                            currentPlayer.Show();
                        }
                        //Console.ReadKey();
                    } while (b);
                    currentPlayer.Position.AddPlayer(currentPlayer);
                }
                else
                {
                    for (int j = 0; j < currentPlayer.Position.list.Count(); j++)
                    {
                        currentPlayer.Position.list[j].Show();
                    }
                    Console.WriteLine("Roll the dice! (hit the enter key)");
                    Console.ReadKey();
                    d = currentPlayer.RollTheDice();
                    if (currentPlayer.NbDouble != 3)
                    {
                        currentPlayer.Position.RemovePlayer(currentPlayer);
                        currentPlayer.Position = board_game.MoveForward(d, currentPlayer.Position);
                        currentPlayer.Jailed = 0;
                        currentPlayer.NbDouble = 3;
                        currentPlayer.Position.AddPlayer(currentPlayer);
                    }
                    else
                    {
                        currentPlayer.Jailed--;
                        if (currentPlayer.Jailed == 0)
                        {
                            currentPlayer.Position.RemovePlayer(currentPlayer);
                            currentPlayer.Position = board_game.MoveForward(d, currentPlayer.Position);
                            currentPlayer.Jailed = 0;
                            currentPlayer.Position.AddPlayer(currentPlayer);
                        }
                    }
                    currentPlayer.Show();
                    //Console.ReadKey();
                }
            }
        }
        public void Display()
        {
            Console.Write("|");
            for (int i = 0; i <= 10; i++)
            {
                if (board_game.GetPosition(i).list.Count != 0)
                {
                    for (int j = 0; j < board_game.GetPosition(i).list.Count; j++)
                    {
                        Console.Write(board_game.GetPosition(i).list[j].Name[0]);
                    }
                    if (board_game.GetPosition(i).list.Count == 1)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write("|");
            }
            Console.WriteLine();
            for (int i = 11; i <= 19; i++)
            {
                Console.Write("|");
                if (board_game.GetPosition(50 - i).list.Count != 0)
                {
                    for (int j = 0; j < board_game.GetPosition(50 - i).list.Count; j++)
                    {
                        Console.Write(board_game.GetPosition(50 - i).list[j].Name[0]);
                    }
                    if (board_game.GetPosition(50 - i).list.Count == 1)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write("|                          |");
                if (board_game.GetPosition(i).list.Count != 0)
                {
                    for (int j = 0; j < board_game.GetPosition(i).list.Count; j++)
                    {
                        Console.Write(board_game.GetPosition(i).list[j].Name[0]);
                    }
                    if (board_game.GetPosition(i).list.Count == 1)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("  ");
                }
                Console.WriteLine("|");
            }
            Console.Write("|");
            for (int i = 30; i >= 20; i--)
            {
                if (board_game.GetPosition(i).list.Count != 0)
                {
                    for (int j = 0; j < board_game.GetPosition(i).list.Count; j++)
                    {
                        Console.Write(board_game.GetPosition(i).list[j].Name[0]);
                    }
                    if (board_game.GetPosition(i).list.Count == 1)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("  ");
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }
    }
}
