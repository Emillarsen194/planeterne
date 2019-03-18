using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planeter
{
    class Program
    {
        static void Main(string[] args)
        {


            
            
            Planet logic = new Planet();

            logic.AddPlanet(); // add our planets 

            Console.WriteLine("\n\n planeter tilføjede"); // planets added 
            foreach (Planet item in logic.Returnlist())
            {
                Console.WriteLine(item.Name); // writes all of our planets

            }


          

            logic.Removeobj1(8); // remove planet at index 8 

            Console.WriteLine("\n\npluto fjernede");  // print our list again 
            foreach (Planet item in logic.Returnlist())
            {
                Console.WriteLine(item.Name);

            }



            logic.AddPluto(); // adds pluto again to planets 
            Console.WriteLine("\n\n pluto tilføjede");
            foreach (Planet item in logic.Returnlist())
            {
                Console.WriteLine(item.Name); // prints our list again

            }


            Console.Write("\n\n antal planeter i listen : "); // shows how many planets in our list 
            logic.HowManyPlanets();
            Console.WriteLine();





            
            


            foreach (Planet item in logic.Returnlist() ) //  prints our list again with planet names 
            {
                Console.WriteLine(item.Name);

            }

            Console.WriteLine("\r\n below 0 mean temparture list : \r\n" );
            
            foreach(Planet item in logic.Returnbelowzero()) // prints our list with planets mean temp under 0 
            {
                Console.WriteLine(item.Name + " "  + "Mean tempature : " + item.MeanTemperature);
            }

            Console.WriteLine("\n\n diameter list added \r\n");

            foreach (Planet item in logic.ReturnDiaList()) // prints our diameter list 
            {
                Console.WriteLine(item.Name);
            }


            logic.Emptylist(); // empty list 

            Console.WriteLine("\n\n Emptied main list with all planets ");
            foreach (Planet item in logic.Returnlist()) // prints all of our planets in our list ( none cause we emptied it ) 
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
    }
    }
}
