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

        Coordinate[] menuSlots;

        Dictionary<ConsoleKey, Commands.Command> commandKeys;        

        #endregion

        #region Constructors

        public StandardMenu(int bW, int bH, int xO, int yO, int w, int h)
            : base(bW, bH, xO, yO, w, h)
        {
            // Set up menu slots for placing command options
            textOrigin = new Coordinate(xO + 1, yO + 1);

            menuSlots = new Coordinate[10];

            for (int i = 0; i < menuSlots.Length; i++)
            {
                // Assign a fresh coordinate for each slot
                // Think of a sensible way to connect each slot
                // with a command.
            }

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

        private void AddCommand(Commands.Command c)
        {
            commandKeys.Add(c.KeyBinding, c);
        }

        #endregion
    }
}
