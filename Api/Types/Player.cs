using Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Types
{
    public class Player : Entity
    {
        public string Name;

        // Memory related stuff can be private/protected
        private ulong Address;
    }
}
