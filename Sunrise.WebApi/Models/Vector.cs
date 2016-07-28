using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunriseVector.Models
{
    public class Vector
    {
        public decimal VectorX { get; set; }
        public decimal VectorY { get; set; }
        public decimal VectorZ { get; set; }

    }

    public class Parameters
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public decimal Hour { get; set; }
        public decimal Minute { get; set; }
        public decimal Second { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


    }
}