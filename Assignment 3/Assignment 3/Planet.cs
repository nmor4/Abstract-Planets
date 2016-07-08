using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    //This is the abstract superclass Planet

    abstract class Planet
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private double _diameter;
        private double _mass;
        private int _mooncount;
        private string _name;
        private double _orbitalperiod;
        private int _ringcount;
        private double _rotationperiod;

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Planet(string name,double diameter, double mass)
        {
            
        }

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public double Diameter
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double Mass
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double RotationPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        // OVERRIDDEN TOSTRING METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
