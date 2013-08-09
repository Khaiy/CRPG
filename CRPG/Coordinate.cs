using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG
{
    public class Coordinate
    {
        #region Fields

        public int xCoordinate;
        public int yCoordinate;

        #endregion

        #region Constructors

        public Coordinate()
        {
        }

        public Coordinate(int x, int y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }

        #endregion
    }
}
