using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CRPG.ConsoleClasses;

namespace CRPG
{
    public class Game
    {
        #region Event Declarations
        #endregion

        #region Fields

        InputListener inputListener;

        #endregion

        #region Constructors

        public Game()
        {
            inputListener = new InputListener();
            inputListener.KeyPressed += new EventHandler<Utilities.KeyEventArgs>(OnKeyPressed);
        }

        #endregion

        #region Methods

        public void Update()
        {
            inputListener.Update();
        }

        #endregion


        #region Event Handlers

        // Input handling method
        public void OnKeyPressed(object sender, Utilities.KeyEventArgs e)
        {
            // Pass key event args to the current game state

            //*//
            if (e.code == ConsoleKey.Escape)
                Console.Title = "Stop being a dick";
            //*//
        }

        #endregion
    }
}
