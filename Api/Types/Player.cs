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
        public int CombatLevel;
        public int CurrentHealth;
        public int MaxHealth;
        // ...more stuff player related

        // Memory related stuff can be private/protected and handled behind the scenes
        private ulong Address;

        // Implement methods here as well
        public override bool DoAction(Common.Action action)
        {
            throw new NotImplementedException();
        }
    }
}
