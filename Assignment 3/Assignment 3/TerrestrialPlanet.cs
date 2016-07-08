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

        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(string name, double diameter,double mass,bool oxygen) :base(name,diameter,mass)
        {
            oxygen = this._oxygen;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //this method returns a true value if the planet object's MoonCount value is greater than zero
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }

        //this method returns a true value if the planet object's Habitable value is true
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
