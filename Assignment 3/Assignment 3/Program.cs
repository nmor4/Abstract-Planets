using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Author: Nick Morin - 300654901
 * Program: COMP123 Assignment 3 - Abstract Planets
 * Date Last Modified: 2016-07-08
 */


namespace Assignment_3
{
    //This is the driver class for the program, which creates new GiantPlanet and TerrestrialPlanet objects and calls thier ToString methods
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139.822, 1898.2,"Gas");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972, true);

            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WaitforAnyKey();
            
        }


        //This method confirms that the user press a key before console is closed
        static void WaitforAnyKey()
        {
            Console.ReadKey();
        }
    }
}
