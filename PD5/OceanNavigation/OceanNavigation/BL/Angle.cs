using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation
{
    internal class Angle
    {
        public int latitiudeDegree;
        public float longitudeDegree;
        public char direction;

        public Angle(int latitudeDegree, float longitudeDegree, char direction)
        {
            this.latitiudeDegree = latitudeDegree;
            this.longitudeDegree = longitudeDegree;
            this.direction = direction; 
        }

        public string concatenate()
        {
            return (latitiudeDegree + "," + longitudeDegree + "," + direction);
        }
       
    }
}
