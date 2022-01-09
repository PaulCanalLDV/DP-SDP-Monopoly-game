using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class PlayerIterator : Iterator
    {
        private Players pList;
        private Player current;
        private int currNum;

        public PlayerIterator(Players pList)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
            this.pList = pList;
        }

        public bool HasNext()
        {
            if (current == null || pList[current] == pList.length() - 1)
            {
                return (pList.head() != null);
            }
            else
            {
                return (pList[pList[current] + 1] != null);
            }
        }

        public Player Next()
        {
            if (current != null || pList[current] == pList.length() - 1)
            {
                current = pList.head();
            }
            else
            {
                current = pList[pList[current] + 1];
            }
            return current;
        }
    }
}
