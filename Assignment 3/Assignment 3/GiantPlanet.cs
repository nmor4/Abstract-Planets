using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    //This is the subclass GiantPlanet
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string name,double diameter,double mass,string type):base(name,diameter,mass)
        {
            type = this._type;
        }

        //PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //this method returns a true value if the planet object's MoonCount value is greater than zero
        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
             return false;
        }

        //this method returns a true value if the planet object's RingCount value is greater than zero
        public bool HasRings()
        {
            if (RingCount>0)
            {
                return true;
            }
            return false;
        }
    }
}
