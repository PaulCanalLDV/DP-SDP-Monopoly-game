using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class PlayerIterator : Iterator
    {
        private Players pList;
        public Player current;
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
            if (current == null || pList[current] == pList.length() - 1)
            {
                //Console.WriteLine("t1");
                current = pList.head();
            }
            else
            {
                //Console.WriteLine("t2");
                current = pList[pList[current] + 1];
            }
            return current;
        }
    }
}
