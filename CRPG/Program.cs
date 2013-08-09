using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG
{
    class Program
    {
        // TODO: Remove test code marked //*//

        static void Main(string[] args)
        {
            int windowWidth = 150;
            int windowHeight = 50;

            //*//
            // Test window setup code
            //Console.WriteLine("{0}, {1}", windowWidth, windowHeight);
            Console.SetWindowSize(150, 50);
            Console.BufferWidth = windowWidth;
            Console.BufferHeight = windowHeight;

            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;

            /*for (int i = 0; i < windowWidth; i++)
            {
                Console.SetCursorPosition(i, 0);

                if (i % pacer == 0)
                    Console.Write("|");
            }*/

            Menus.StandardMenu sm = new Menus.StandardMenu(windowWidth, windowHeight,
                windowWidth - 15, 0, 15, 50);
            //*//

            // Create the Game object
            Game g = new Game();

            // Begin game loop
            bool running = true;

            while (running)
            {
                sm.DrawBorder();

                //*//
                Console.SetCursorPosition(5, 5);
                Console.Write(sm.test.ToString());
                //*//

                g.Update();
            }
        }
    }
}
