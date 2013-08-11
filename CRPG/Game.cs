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

        Menu currentMenu;

        #endregion

        #region Constructors

        public Game(int windowWidth, int windowHeight)
        {
            inputListener = new InputListener();
            inputListener.KeyPressed += new EventHandler<Utilities.KeyEventArgs>(OnKeyPressed);

            currentMenu = new Menus.StandardMenu(windowWidth, windowHeight,
                windowWidth - 15, 0, 15, windowHeight);
        }

        #endregion

        #region Methods

        public void Update()
        {
            currentMenu.Draw();
            inputListener.Update();
        }

        #endregion


        #region Event Handlers

        // Input handling method
        public void OnKeyPressed(object sender, Utilities.KeyEventArgs e)
        {
            // Pass key event args to the current game state
            currentMenu.HandleInput(e);

            //*//
            if (e.code == ConsoleKey.Escape)
                Console.Title = "Stop being a dick";
            //*//
        }

        #endregion
    }
}
