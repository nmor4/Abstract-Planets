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
            
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }
    }
}
