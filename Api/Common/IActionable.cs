﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Common
{
    public interface IActionable
    {
        bool DoAction(Action action); // Other params maybe?
    }
}
