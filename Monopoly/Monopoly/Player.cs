using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Player
    {
        private string name;
        private Position position;
        private bool jailed = false;
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
        public bool Jailed   // property
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

            int dé1 = rnd.Next(1, 6);
            int dé2 = rnd.Next(1, 6);
            int total = dé1 + dé2;
            if (dé1 == dé2)
            {
                nbDouble--;
            }
            Console.WriteLine("dé1 =" + dé1);
            Console.WriteLine("dé2 =" + dé2);

            return total;
        }
        public void Show()
        {
            Console.WriteLine(name + " " + position.number + " " + jailed + " " + nbDouble);
        }
    }
}
