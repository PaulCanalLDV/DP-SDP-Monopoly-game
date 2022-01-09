using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class MyPositionFactory : PositionFactory
    {
        public override Position createPosition(PositionType type)
        {
            switch(type)
            {
                case PositionType.STANDARD:
                    return new StandardPosition();

                case PositionType.JAIL:
                    return Jail.GetJail();

                case PositionType.GOTOJAIL:
                    return GoToJail.GetGoToJail();

                default:
                    return null;
            }
        }
    }
}
