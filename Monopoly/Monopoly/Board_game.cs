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

        public void AddPosition (Position pos)
        {
            if (head == null)
            {
                head = pos;
            }
            else
            {
                Position last = LastPosition();
                last.next = pos;
            }
        }

        public Position LastPosition()
        {
            return head != null ? GetPosition(length() - 1) : null;
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
        public Position GetPosition(int p)
        {
            Position current = head;
            while (current != null)
            {
                if (p == 0)
                {
                    return current;
                }
                current = current.next;
                p--;
            }
            return null;
        }
        /*
        public Position GetPosition(Position pos)
        {

        }
        */
        public void ConnectHeadLast()
        {
            Position last = LastPosition();
            last.next = head;
        }
        public Board_game()
        {
            head = new Position(0);
            Position current = head;
            for (int i = 1; i < 40; i++)
            {
                current.next = new Position(i);
                current = current.next;
            }
            ConnectHeadLast();
        }
        public Position MoveForward(int n, Position p)
        {
            Position current = p;
            for (int i = 0; i <= n; i++)
            {
                current = current.next;
            }
            return current;
        }
        public void Show()
        {
            Position current = head;
            for (int i = 0; i < 40; i++)
            {
                current.Show();
                current = current.next;
            }
        }
    }
}
