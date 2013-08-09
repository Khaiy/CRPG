using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.ConsoleClasses
{
    public class InputListener
    {
        #region Event Declarations
        
        public event EventHandler<Utilities.KeyEventArgs> KeyPressed;

        #endregion

        #region Fields

        ConsoleKeyInfo keyPress;

        #endregion

        #region Constructors

        public InputListener()
        {
        }

        #endregion

        #region Methods

        public void Update()
        {
            keyPress = Console.ReadKey(true);

            Key_Pressed(keyPress);
        }

        private void Key_Pressed(ConsoleKeyInfo k)
        {
            Utilities.KeyEventArgs args = new Utilities.KeyEventArgs(k);

            if (KeyPressed != null)
                this.KeyPressed(this, args);
        }

        #endregion
    }
}
