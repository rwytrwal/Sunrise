using System;
using System.Data;
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
            DateTime calendarData = new DateTime(2003, 1, 1, 16, 0, 0);
            Console.WriteLine("czas1" + calendarData.ToString());
            Console.WriteLine(DateTime.Now.ToString("%K"));
            calendarData = calendarData.ToUniversalTime();
            Console.WriteLine("czas2" + calendarData.ToString());
            TimeZone zone = TimeZone.CurrentTimeZone;
            // Get offset.
            TimeSpan offset = zone.GetUtcOffset(DateTime.Now);
            calendarData.Hour = calendarData.Hour + offset;
            PositionCoordinate positionCoordinate = new PositionCoordinate
            {
                UdtLocationdLatitude = 0,
                UdtLocationdLongitude = 0
            };

            calculateVector.SunPos(calendarData,
                        positionCoordinate.UdtLocationdLatitude,
                        positionCoordinate.UdtLocationdLongitude);
            
            runMain.PrintOutput(PrintSunVector.X, PrintSunVector.Y, PrintSunVector.Z);

            Console.Read();
        }
    }
}
