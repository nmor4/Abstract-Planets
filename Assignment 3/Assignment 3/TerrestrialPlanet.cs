using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    //This is the subclass TerrestrialPlanet
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter,double mass,bool oxygen) :base(name,diameter,mass)
        {
            oxygen = this._oxygen;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }

        public bool Habitable()
        {
            if (this._oxygen ==true)
            {
                return true;
            }
            return false;
        }
    }
}
