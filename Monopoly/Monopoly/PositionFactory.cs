using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public enum PositionType { STANDARD, JAIL, GOTOJAIL };
    abstract class PositionFactory
    {
        public abstract Position createPosition(PositionType type);
    }
}
