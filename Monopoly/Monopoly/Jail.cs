using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // The Jail class uses a singleton pattern, since there is only one jail on the board game
    class Jail : Position
    {
        static Jail instance;

        protected Jail() : base(10) // the jail is always at the 11nth position, so position 10
        {
        }

        public static Jail GetJail()
        {
            if (instance == null)
            {
                instance = new Jail();
            }
            return instance;
        }

        public override void Show()
        {
            Console.WriteLine("Jail (10)");
        }
    }
}
