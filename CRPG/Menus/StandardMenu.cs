using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.Menus
{
    public class StandardMenu : ConsoleClasses.Menu
    {
        #region Fields
        //*// Test Field
        public Command test = new Command(ConsoleKey.A, "testorizer");
        //*//

        #endregion

        #region Constructors

        public StandardMenu()
        {
        }

        public StandardMenu(int bW, int bH, int xO, int yO, int w, int h)
            : base(bW, bH, xO, yO, w, h)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
