using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.Menus
{
    public class Command
    {
        // TODO: Write methods allowing the user to dynamically bind keys to a command
        // TODO: Write methods that can respond to key presses
        #region Fields

        string name;
        ConsoleKey keyBinding;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                string boundKey = "(" + keyBinding.ToString() + ")";
                string toDisplay = boundKey + " " + name;

                return toDisplay;
            }

            private set
            {
                name = value;
            }
        }

        #endregion

        #region Constructors

        public Command(ConsoleKey key, string commandName)
        {
            keyBinding = key;
            name = commandName;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
