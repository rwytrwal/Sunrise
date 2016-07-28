using System;
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
            DateTime calendarData = new DateTime(2016, 7, 28, 16, 0, 0);
            calendarData = calendarData.ToUniversalTime();

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
