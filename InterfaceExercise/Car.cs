using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public bool trunk { get; set; }

        public int bedSize { get; set; }

        public int tire { get; set; }

        public int window { get; set; }

        public int wheel { get; set; }

        public string VIN { get; set; }

        public string logo { get; set; }

        public int EIN { get; set; }

        public void CarInfo(bool trunks, int tires, int windows, int wheels)
        {
            trunk = trunks;
            tires = tire;
            windows = window;
            wheels = wheel;

            Console.WriteLine("----- Car info ------");

            Console.WriteLine($" Car has Trunk? {true}, \n Number of tires={tire}, \n Number of Windows={windows}, \n Number of wheels={wheels}" );
            Console.WriteLine();
        }
    }
}
