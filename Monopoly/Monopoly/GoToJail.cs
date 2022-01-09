using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class GoToJail : Position
    {
        static GoToJail instance;

        protected GoToJail() : base(30) // the gotojail is always at the 31th position, so position 30
        {
        }

        public static GoToJail GetGoToJail()
        {
            if (instance == null)
            {
                instance = new GoToJail();
            }
            return instance;
        }
        public override void Show()
        {
            Console.WriteLine("GoToJail (30)");
        }
    }
}
