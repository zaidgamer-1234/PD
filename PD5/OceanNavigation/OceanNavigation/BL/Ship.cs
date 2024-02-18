using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation
{
    internal class Ship
    {
        public string shipNumber;
        public Angle shipsLatitude;
        public Angle shipsLongitude;

        public Ship(string shipNumber,Angle a)
        {
            this.shipNumber = shipNumber;
            shipsLatitude = a;
            
        }

        public string position()
        {
            return "ship is at " + shipsLatitude.concatenate();
        }


    }
}
