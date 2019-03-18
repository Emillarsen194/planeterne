using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planeter
{

    //static list
    class Planet
    {

        static List<Planet> planeterne = new List<Planet>();      // list with planets
        static List<Planet> planeternebelowzero = new List<Planet>(); //list with planets below mean tempature under 0 
        static List<Planet> diameterbelow = new List<Planet>(); // list with plants below 50000 and more than 10000 diameter

        private string name;
        private double mass;
        private double diameter;
        private int density;
        private float gravity;
        private float rotations;
        private double lengthOfDay;
        private double distanceFromSun;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private int meanTemperature;
        private byte numberOfMoons;
        private String ringsystem;

        #region makeallpublic
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                diameter = value;
            }
        }

        public int Density
        {
            get
            {
                return density;
            }

            set
            {
                density = value;
            }
        }

        public float Gravity
        {
            get
            {
                return gravity;
            }

            set
            {
                gravity = value;
            }
        }

        public float Rotations
        {
            get
            {
                return rotations;
            }

            set
            {
                rotations = value;
            }
        }

        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }

            set
            {
                lengthOfDay = value;
            }
        }

        public double DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }

            set
            {
                distanceFromSun = value;
            }
        }

        public float OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }

            set
            {
                orbitalPeriod = value;
            }
        }

        public float OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }

            set
            {
                orbitalVelocity = value;
            }
        }

        public int MeanTemperature
        {
            get
            {
                return meanTemperature;
            }

            set
            {
                meanTemperature
 = value;
            }
        }

        public byte NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }

            set
            {
                numberOfMoons = value;
            }
        }

        public String Ringsystem
        {
            get
            {
                return ringsystem;
            }

            set
            {
                ringsystem = value;
            }
        }
        #endregion





        public Planet()
        {

        }


        public Planet(String n, double ma, double dia, int dens, float gravi, float rot, double day,
                      double fromSun, float oPeriod, float oVelocity, int meanT, byte moons, String rings)
        {
            this.name = n;
            this.mass = ma;
            this.diameter = dia;
            this.density = dens;
            this.gravity = gravi;
            this.rotations = rot;
            this.lengthOfDay = day;
            this.distanceFromSun = fromSun;
            this.orbitalPeriod = oPeriod;
            this.orbitalVelocity = oVelocity;
            this.meanTemperature = meanT;
            this.numberOfMoons = moons;
            this.ringsystem = rings;


            planeterne.Add(this); //adds the planets to our list 

            if (meanT < 0) // if mean temperture on planets is below 0 add this to our planterernebelowzero list 
            {
                planeternebelowzero.Add(this);
            }

            if (dia < 50000 && dia > 10000) // if diameter is under 50000 and over 10000 add those planets to our diameterbelow list 
            {
                diameterbelow.Add(this);
            }

        }



        public List<Planet> Returnlist() // returns our list here 
        {
            return planeterne;
        }

        public List<Planet> Returnbelowzero()
        {
            return planeternebelowzero;
        }

        public List<Planet> ReturnDiaList()
        {
            return diameterbelow;
        }


        public void AddPluto() // adds object pluto 
        {
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7F, -153.3F, 153.3, 5906.4, 90.56F, 4.7F, -225, 5, "no");
            
        }




        public void Removeobj1(int indextoremove) //remove planet at index to remove we give it index in our main 
        {

         

            planeterne.RemoveAt(indextoremove);

           

        }

        public void HowManyPlanets() // counts how many planets we have 
        {
            Console.WriteLine(planeterne.Count());
        }

        public void Emptylist() // empty our planet list 
        {
            planeterne.Clear();
        }











        public void AddPlanet() //makes planet object with the given information in the constructor 
        {
            Planet merkur = new Planet("Merkur", 0.330, 4869, 5427, 3.7F, 1407.6F, 4222.6, 57.9, 88.0F, 47.4F, 167, 0, "no");
            Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9F, -5832.5F, 2802.0, 108.2, 224.7F, 35.0F, 464, 0, "no");
            Planet jorden = new Planet("Jorden", 5.97, 12104, 5514, 9.8F, 23.9F, 24.0, 149.6, 365.2F, 29.8F, 15, 1, "no");
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7F, 24.6F, 24.7, 227.9, 687.0F, 24.1F, -65, 2, "no");
            Planet jupiter = new Planet("Jupiter", 1898, 142.984, 1326, 23.1F, 9.9F, 9.9, 778.6, 4431, 13.1F, -110, 67, "yes");
            Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0F, 10.7F, 10.7, 1433.5, 10.747F, 9.7F, -140, 62, "yes");
            Planet uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7F, -17.2F, 17.2, 2872.5, 30.589F, 6.8F, -195, 27, "yes");
            Planet neptun = new Planet("Neptun", 102, 49528, 1638, 11.0F, 16.1F, 16.1, 4495.1, 59.8F, 5.4F, -200, 14, "yes");
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7F, -153.3F, 153.3, 5906.4, 90.56F, 4.7F, -225, 5, "no");
            
        }

        
            

           






       


    }
}
