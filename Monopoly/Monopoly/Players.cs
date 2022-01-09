using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Players : Aggregate
    {
        List<Player> list;

        public PlayerIterator CreateIterator()
        {
            return new PlayerIterator(this);
        }

        public Player head()
        {
            return list.First();
        }
        
        public int length()
        {
            return list.Count;
        }

        public Player this[int index]
        {
            get
            {
                return list[index];
            }
        }
    }
}
