using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        private string name;
        private Position position;
        private int jailed = 0;
        private int nbDouble = 3;

        public Player(string name, Position pos0)
        {
            this.name = name;
            position = pos0;
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public Position Position   // property
        {
            get { return position; }   // get method
            set { position = value; }  // set method
        }
        public int Jailed   // property
        {
            get { return jailed; }   // get method
            set { jailed = value; }  // set method
        }
        public int NbDouble   // property
        {
            get { return nbDouble; }   // get method
            set { nbDouble = value; }  // set method
        }

        public int RollTheDice()
        {

            Random rnd = new Random();

            int dé1 = rnd.Next(1, 7);
            int dé2 = rnd.Next(1, 7);
            int total = dé1 + dé2;
            if (dé1 == dé2)
            {
                nbDouble--;
            }
            else
            {
                nbDouble = 3;
            }
            Console.WriteLine("die 1 =" + dé1);
            Console.WriteLine("die 2 =" + dé2);

            return total;
        }
        public void Show()
        {
            Console.Write("Name : " + name + " | Position : " + (position.number + 1) + " | ");
            if (jailed == 0)
            {
                Console.WriteLine("Not in jail | Number of doubles : " + nbDouble);
            }
            else
            {
                Console.WriteLine("In jail for " + jailed + " turns | Number of doubles : " + nbDouble);
            }
        }
    }
}
