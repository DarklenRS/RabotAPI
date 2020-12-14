using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Common
{
    public interface IPositionable
    {
        Position Position { get; set; }

        int GetWorldX();
        int GetWorldY();
        int GetWorldZ();
 
    }
}
