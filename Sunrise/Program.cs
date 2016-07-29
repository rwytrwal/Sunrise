using System;
using System.Globalization;
using Sunrise.Calculate;


namespace Sunrise
{
    class ConsoleOut : ComputeVector
    {
        public void PrintOutput(decimal x, decimal y, decimal z)
        {
            Console.WriteLine("Sun's Position to High Accuracy");
            Console.WriteLine("Azimuth: " + x);
            Console.WriteLine("Zenith: " + y);
            Console.WriteLine("Elevation: " + z);
        }
        static void Main(string[] args)
        {
            ConsoleOut runMain = new ConsoleOut();
            ComputeVector calculateVector = new ComputeVector();
            string isoFormatDate = "yyyy-MM-ddTHH:mm:sszzz";
            TimeSpan a = new TimeSpan(-2, 0, 0);
            DateTimeOffset calendarData = new DateTimeOffset(2016, 7, 28, 16, 0, 0, a);
            string time = "2016-01-23T13:12:20+02:00";
            DateTime newData = DateTime.ParseExact(time, isoFormatDate, new CultureInfo("en-US"));
            Console.WriteLine("prasowany " + calendarData);
            calendarData = calendarData.ToUniversalTime();
            Console.WriteLine("uni22 " + newData);
            Console.WriteLine("uni "+calendarData);
            PositionCoordinate positionCoordinate = new PositionCoordinate
            {
                UdtLocationdLatitude = 0,
                UdtLocationdLongitude = 0
            };

            calculateVector.SunPos(calendarData,
                        positionCoordinate.UdtLocationdLatitude,
                        positionCoordinate.UdtLocationdLongitude);
            
            runMain.PrintOutput(PrintSunVector.AzimutDecimal, PrintSunVector.ZenithDecimal, PrintSunVector.ElevationDecimal);

            Console.Read();
        }
    }
}
