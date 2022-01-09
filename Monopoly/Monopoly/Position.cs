using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class Position
    {
        public int number { get; set; }
        public Position next { get; set; }

        public Position()
        {
        }
        public Position(int num)
        {
            number = num;
            next = null;
        }
        public virtual void Show()
        {
            Console.WriteLine(number);
        }
    }
}
