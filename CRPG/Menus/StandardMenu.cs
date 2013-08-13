using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRPG.Commands;

namespace CRPG.Menus
{
    public class StandardMenu : ConsoleClasses.Menu
    {
        #region Fields
        //*// Test Field
        // public Command test = new Command(ConsoleKey.A, "testorizer");
        //*//

        Go go;
        Examine examine;

        Coordinate textOrigin;

        Dictionary<ConsoleKey, Commands.Command> commandKeys;

        Dictionary<Command, Coordinate> menuSlots;

        #endregion

        #region Constructors

        public StandardMenu(int bW, int bH, int xO, int yO, int w, int h)
            : base(bW, bH, xO, yO, w, h)
        {
            // Set up commands
            go = new Go(ConsoleKey.G);
            examine = new Examine(ConsoleKey.E);            

            // Link console keys to their assigned commands
            commandKeys = new Dictionary<ConsoleKey, Commands.Command>();

            commandKeys.Add(go.KeyBinding, go);
            commandKeys.Add(examine.KeyBinding, examine);

            // Set screen positions from commands, then populate
            // the menuSlots dictionary
            // This approach seems awkward and ugly.
            // Consider for major refactor.
            menuSlots = new Dictionary<Command, Coordinate>();

            textOrigin = new Coordinate(xO + 1, yO + 1);

            int yOffset = 0;

            for (int i = 0; i < commandKeys.Count; i++)
            {
                Command currentCommand = commandKeys.ElementAt(i).Value;

                menuSlots.Add(currentCommand,
                    new Coordinate(textOrigin.xCoordinate,
                    textOrigin.yCoordinate + yOffset));

                yOffset++;
            }


        }

        #endregion

        #region Methods

        public override void Draw()
        {
            // This bit feels awkward. Consider a major
            // refactor.
            foreach (Commands.Command c in commandKeys.Values)
            {
                // Set cursor position, draw command
                int xPosition = menuSlots[c].xCoordinate;
                int yPosition = menuSlots[c].yCoordinate;

                Console.SetCursorPosition(xPosition, yPosition);

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
