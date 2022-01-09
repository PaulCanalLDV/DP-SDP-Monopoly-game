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
        private int position;
        private bool jailed;
        private int nbDouble = 3;

        public Player(string name)
        {

            this.name = name;
        }

        public int Position   // property
        {
            get { return position; }   // get method
            set { position = value; }  // set method
        }

        public bool Jailed   // property
        {
            get { return jailed; }   // get method
            set { jailed = value; }  // set method
        }

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
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
            Console.WriteLine(name);
        }
    }
}
