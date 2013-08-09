using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG
{
    public class Room
    {
        #region Fields

        // Size represents a total area
        int size;

        // Blech
        Room adjoiningNorth;
        Room adjoiningEast;
        Room adjoiningSouth;
        Room adjoiningWest;

        #endregion
    }
}
