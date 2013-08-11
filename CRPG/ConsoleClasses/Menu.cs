using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG.ConsoleClasses
{
    public abstract class Menu
    {
        // TODO: Write methods that can read key presses and pass them to the appropriate controls
        #region Fields

        int bufferWidth;
        int bufferHeight;

        int xOrigin; // 35
        int yOrigin;

        int height;
        int width;

        Menu previousMenu;
        
        // Experimental
        int nestDepth;

        #endregion

        #region Constructors

        public Menu()
        {
        }

        public Menu(int bW, int bH, int xO, int yO, int w, int h)
        {
            bufferWidth = bW;
            bufferHeight = bH;
            xOrigin = xO;
            yOrigin = yO;
            width = w;
            height = h;

            nestDepth = 0;
        }

        public Menu(int bW, int bH, int xO, int yO, int w, int h, Menu previous)
        {
            bufferWidth = bW;
            bufferHeight = bH;
            xOrigin = xO;
            yOrigin = yO;
            width = w;
            height = h;

            previousMenu = previous;

            nestDepth = previous.nestDepth + 1;
        }

        #endregion

        #region Methods

        public virtual void Draw()
        {
            DrawBorder();
        }

        public virtual void Update()
        {
        }

        public virtual void HandleInput(Utilities.KeyEventArgs e)
        {
        }

        private void DrawBorder()
        {
            int maxDrawableX = bufferWidth - 1;
            int maxDrawableY = bufferHeight - 2; // To prevent window scrolling

            int currentRow = this.yOrigin;
            int currentColumn = this.xOrigin;

            Console.SetCursorPosition(currentColumn, currentRow);

            for (int y = 0; y < height - 1; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Draw corners and horizontal edges
                    if (x == 0 || currentColumn == maxDrawableX)
                    {
                        if (y == 0 || currentRow == maxDrawableY)
                             Console.Write("O");

                        else
                            Console.Write("|");
                    }

                    // Draw vertical edges
                    else if (y == 0 || currentRow == maxDrawableY)
                        Console.Write("=");

                    // Check cursor position for validity ahead of update
                    if (currentColumn != maxDrawableX)
                    {
                        currentColumn++;
                        Console.SetCursorPosition(currentColumn, currentRow);
                    }

                    else
                        currentColumn = xOrigin;
                }

                // Update cursor position for next row
                if (currentRow != maxDrawableY)
                {
                    currentRow++;
                    currentColumn = xOrigin;
                    Console.SetCursorPosition(currentColumn, currentRow);
                }

                else
                    currentRow = yOrigin;
            }
        }

        #endregion
    }
}
