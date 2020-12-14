using Api.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public static class LocalPlayer
    {
        public static Player Player;
        public static int GetCurrentHealth()
        {
            return Player.CurrentHealth;
        }
    }
}
