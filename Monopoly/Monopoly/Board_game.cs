using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Board_game
    {
        protected Position head;

        public void addPosition (Position pos)
        {
            if (head == null)
            {
                head = pos;
            }
            else
            {
                Position last = lastPosition();
                last.next = pos;
            }
        }

        public Position lastPosition()
        {
            return head == null ? getPosition 
        }
        public int length()
        {
            int l = 0;
            Position current = head;
            while(current != null)
            {
                current = current.next;
                l++;
            }
            return l;
        }

    }
}
