using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int tire { get; set; }

        public int window { get; set; }

        public int wheel { get; set; }

        public string VIN { get; set; }

    }
}
