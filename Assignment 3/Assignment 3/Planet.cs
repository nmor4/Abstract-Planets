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
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public double Diameter
        {
            get
            {
                return _diameter;
            }

           
        }

        public  double Mass
        {
            get
            {
                return _mass;
            }

           
        }

        public  int MoonCount
        {
            get
            {
                return this._mooncount;
            }

            set
            {
                
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalperiod;
            }

            set
            {
                this._orbitalperiod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringcount;
            }

            set
            {
                this._ringcount = value;
                
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationperiod;
            }

            set
            {
                this._rotationperiod = value;
            }
        }

        // OVERRIDDEN TOSTRING METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string planetInfo = "Name: "+ this._name +"\nDiameter: " +this._diameter+" thousands of kilometers \nMass: "+this._mass+ " x 10^24 kilograms\n";
           
            Console.WriteLine(planetInfo);
                return planetInfo;
                 
            
        }
    }
}
