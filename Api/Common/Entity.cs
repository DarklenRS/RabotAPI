using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Common
{
    public abstract class Entity : IPositionable, IActionable
    {
        public Position Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool DoAction(Action action)
        {
            throw new NotImplementedException();
        }

        public int GetWorldX()
        {
            return Position.X;
        }

        public int GetWorldY()
        {
            return Position.Y;
        }

        public int GetWorldZ()
        {
            return Position.Z;
        }
    }
}
