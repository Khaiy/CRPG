using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.Commands
{
    public class Go : Command
    {
        #region Fields
        #endregion

        #region Constructors

        public Go(ConsoleKey cK)
            : base(cK, "Go")
        {
        }

        #endregion

        #region Methods

        public override void HandleInput()
        {
            // Implement function allowing character
            // to change locations
        }

        #endregion
    }
}
