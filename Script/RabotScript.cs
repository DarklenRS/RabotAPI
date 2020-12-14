using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script
{
    public abstract class Script
    {
        public abstract void OnStart();
        public abstract void OnStop();
        public abstract int Loop();
    }
}
