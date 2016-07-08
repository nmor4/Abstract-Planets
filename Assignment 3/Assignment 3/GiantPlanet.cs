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

        public GiantPlanet(string name,double diameter,double mass,string type):base(name,diameter,mass)
        {
            type = this._type;
        }

        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
             return false;
        }

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
