using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRPG
{
    public class Location
    {
        #region Fields

        public Coordinate coordinates;
        public List<Location> subLocations;
        public Location superLocation;
        // Size (dimensions)
        // Unit of measure (for scale)

        #endregion

        #region Constructors

        public Location(int x, int y)
        {
            coordinates = new Coordinate(x, y);
        }

        public Location(int x, int y, List<Location> subs,
            Location super)
        {
            coordinates = new Coordinate(x, y);

            subLocations = subs;

            superLocation = super;
        }

        #endregion
    }
}
