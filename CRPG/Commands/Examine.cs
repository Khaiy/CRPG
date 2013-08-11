using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.Commands
{
    public class Examine : Command
    {
        #region Fields
        #endregion

        #region Constructors

        public Examine(ConsoleKey cK)
            : base(cK, "Examine")
        {
        }

        #endregion

        #region Methods

        public override void HandleInput()
        {
            //*//
            Console.SetCursorPosition(10, 10);
            Console.Write("You do not notice anything unusual.");
            //*//
        }

        #endregion
    }
}
