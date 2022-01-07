using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Position
    {
        public int number { get; set; }
        public List<Player> list { get; set; }
        public Position next { get; set; }

        public Position(int num)
        {
            number = num;
            list = null;
            next = null;
        }
    }
}
