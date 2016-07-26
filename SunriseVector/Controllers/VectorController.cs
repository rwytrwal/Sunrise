using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunrise.Calculate;
using SunriseVector.Models;


namespace SunriseVector.Controllers
{
    public class VectorController : ApiController
    {
        Vector vector;
        private ComputeVector dupa = new ComputeVector();
        public static SunVector PrintSunVector = new SunVector();
        PositionCoordinate _data = new PositionCoordinate
        {
            UdtLocationdLatitude = 0,
            UdtLocationdLongitude = 0
        };
        readonly DateTime _newData = new DateTime(2003, 1, 1, 1, 12, 0);

        public Vector GetVector()
        {
            dupa.SunPos(_newData,
                        _data.UdtLocationdLatitude,
                        _data.UdtLocationdLongitude);
            
            return vector;
        }
    }
}
