using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunrise.Calculate;


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
        public SunVector GetVector(string time, double latitude, double longitude)
        {
            string isoFormatDate = "yyyy-MM-ddTHH:mm:ss";
            try
            {
                DateTime newData = DateTime.ParseExact(time, isoFormatDate, new CultureInfo("en-US"));
                newData = newData.ToUniversalTime();
                return _compute.SunPos(newData,
                    _data.UdtLocationdLatitude = latitude,
                    _data.UdtLocationdLongitude = longitude);

            }
            catch (Exception e)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Valid Parameters : " + e)),
                };
                    throw new HttpResponseException(resp);
             
            }

        }
        [Route("data")]
        [HttpGet]
        public SunVector GetVector(double latitude, double longitude)
        {
            try
            {
                DateTime newData = DateTime.Now;
                newData = newData.ToUniversalTime();
                return _compute.SunPos(newData,
                    _data.UdtLocationdLatitude = latitude,
                    _data.UdtLocationdLongitude = longitude);

            }
            catch (Exception e)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format("Valid Parameters" + e)),
                };
                throw new HttpResponseException(resp);

            }

        }
    }
}



