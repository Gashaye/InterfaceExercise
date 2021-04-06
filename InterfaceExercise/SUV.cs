using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {        

        public int bedSize { get; set; }

        public bool cargoSize { get; set; }

        public int tire { get; set; }

        public int window { get; set; }

        public int wheel { get; set; }

        public string VIN { get; set; }

        public string logo { get; set; }

        public int EIN { get; set; }

        public void SUVInfo(int cargoSizes)
        {
            int cargosize = cargoSizes;

            Console.WriteLine( "----  SUV Info ----");
        
            Console.WriteLine("CargoSize in inch: " + cargoSizes);
            Console.WriteLine();
            
        }
    }
}
