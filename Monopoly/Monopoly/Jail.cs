using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Jail : Position
    {
        public List<Player> listPlayersInJail { get; set; }

        public Jail() : base(10) // the jail is always at the 11nth position, so position 10
        {
            listPlayersInJail = null;
        }
    }
}
