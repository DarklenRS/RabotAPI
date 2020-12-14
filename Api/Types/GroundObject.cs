using Api.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Types
{
    public class GroundObject : IPositionable, IActionable
    {
        public Position Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool DoAction(Common.Action action)
        {
            throw new NotImplementedException();
        }

        public int GetWorldX()
        {
            throw new NotImplementedException();
        }

        public int GetWorldY()
        {
            throw new NotImplementedException();
        }

        public int GetWorldZ()
        {
            throw new NotImplementedException();
        }
    }
}
