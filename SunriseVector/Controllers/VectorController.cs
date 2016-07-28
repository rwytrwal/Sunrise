using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunrise.Calculate;
using SunriseVector.Models;


namespace SunriseVector.Controllers
{
    [RoutePrefix("api/vector")]
    public class VectorController : ApiController
    {

        private readonly ComputeVector _compute = new ComputeVector();
        public static SunVector PrintSunVector = new SunVector();

        PositionCoordinate _data = new PositionCoordinate
        {
            UdtLocationdLatitude = 0,
            UdtLocationdLongitude = 0
        };

        [Route("data")]
        [HttpGet]
        public SunVector GetVector(string time, int latitude, int longitude)
        {
            string format = "yyyy-MM-ddTHH:mm:ss";

            try
            {
                DateTime _newData = DateTime.ParseExact(time, format, new CultureInfo("en-US"));
                
                return _compute.SunPos(_newData,
                    _data.UdtLocationdLatitude = latitude,
                    _data.UdtLocationdLongitude = longitude);       

            }
            catch (Exception)
            {
                return null;
                throw ;
            }

        }
    }
}



