using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunriseVector.Models
{
    /// <summary>
    /// SunriseVector class
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// SunriseVector AzimutDecimal
        /// </summary>
        public decimal VectorX { get; set; }
        /// <summary>
        /// SunriseVector ZenithDecimal
        /// </summary>        
        public decimal VectorY { get; set; }
        /// <summary>
        /// SunriseVector ElevationDecimal
        /// </summary>        
        public decimal VectorZ { get; set; }

    }

   
}
