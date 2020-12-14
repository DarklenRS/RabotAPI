using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Types
{
    public class Prayer
    {
        public Prayer() { }

        public static Prayer PROTECT_MELEE = new Prayer();
        public static Prayer PROTECT_RANGED = new Prayer();
        public static Prayer PROTECT_MAGIC = new Prayer();
        public static Prayer IRON_SKIN = new Prayer();

        
    }
}
