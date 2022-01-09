using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class GoToJail : Position
    {
        static GoToJail instance;

        protected GoToJail() : base(30) // the gotojail is always at the 31th position, so position 30
        {
        }

        public static GoToJail GetGoToJail()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked            return instance;
            if (instance == null)
            {
                instance = new GoToJail();
            }
            return instance;
        }
    }
}
