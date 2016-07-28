using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sunrise.Calculate;


namespace SunriseVector.Controllers
{
    /// <summary>
    /// SunriseVector controller
    /// </summary>
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
        /// <summary>
        /// Get DataTime, Locationd Latitude and Longitude
        /// </summary>
        /// <remarks>Return list of all products or exception</remarks>
        /// <response code="200">OK</response>
        /// <response code="204">Valid Parameters</response>
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
        /// <summary>
        /// Get Locationd Latitude and Longitude
        /// </summary>
        /// <remarks>Return list of all products or exception</remarks>
        /// <response code="200">OK</response>
        /// <response code="204">Valid Parameters</response>
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



