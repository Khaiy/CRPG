using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.Utilities
{
    public class KeyEventArgs : EventArgs
    {
        public ConsoleKey code { get; private set; }

        public KeyEventArgs(ConsoleKeyInfo value)
        {
            code = value.Key;
        }
    }
}
