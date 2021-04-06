using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public int bedSize { get; set; }

        public int tire { get; set; }

        public int window { get; set; }

        public int wheel { get; set; }

        public string VIN { get; set; }

        public string logo { get; set; }

        public int EIN { get; set; }

        public void TruckInfo(int bedSizes)
        {
            int bedSize = bedSizes;

            Console.WriteLine(" -----  Truck Info ---");
            Console.WriteLine("Truck bed  Size in Inch: " + bedSizes);

        }

    }
}
