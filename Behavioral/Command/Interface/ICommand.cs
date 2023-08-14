﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    // The Command interface declares a method for executing a command.
    public interface ICommand
    {
        void Execute();
    }
}
