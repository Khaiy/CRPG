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
        // public Command test = new Command(ConsoleKey.A, "testorizer");
        //*//

        Coordinate textOrigin;

        Dictionary<ConsoleKey, Commands.Command> commandKeys;        

        #endregion

        #region Constructors

        public StandardMenu(int bW, int bH, int xO, int yO, int w, int h)
            : base(bW, bH, xO, yO, w, h)
        {
            textOrigin = new Coordinate(xO + 1, yO + 1);

            commandKeys = new Dictionary<ConsoleKey, Commands.Command>();

            commandKeys.Add(ConsoleKey.E,
                new Commands.Examine(ConsoleKey.E));
        }

        #endregion

        #region Methods

        public override void Draw()
        {
            foreach (Commands.Command c in commandKeys.Values)
            {
                // Set cursor position, draw command
                Console.SetCursorPosition(textOrigin.xCoordinate,
                    textOrigin.yCoordinate);

                Console.Write(c.ToString());
            }

            base.Draw();
        }

        public override void HandleInput(Utilities.KeyEventArgs e)
        {
            if (commandKeys.ContainsKey(e.code))
                commandKeys[e.code].HandleInput();
        }

        #endregion
    }
}
