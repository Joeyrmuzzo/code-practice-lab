using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7_collaboration_project
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] planet = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            double[] diameter = new double[] { 4879, 12104, 12756, 6792, 142984, 120536, 51118, 49528 };

            planets(planet, diameter);
            
            //the display is inside the function
            
            Console.ReadLine();


        }
        public static void planets(string[] planet, double[] diameter)
        {
            Console.WriteLine("Each planet and its diameter are shown below:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("\nPlanet: " + planet[i]);//display
                Console.Write("\tDiameter: " + diameter[i]);//display
            }

            
        }
    }


}

