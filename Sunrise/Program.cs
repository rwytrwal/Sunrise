using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunrise;
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
            DateTime newData = new DateTime(2003, 1, 1, 1, 12, 0);
            PositionCoordinate data = new PositionCoordinate
            {
                UdtLocationdLatitude = 0,
                UdtLocationdLongitude = 0
            };

            calculateVector.SunPos(newData,
                        data.UdtLocationdLatitude,
                        data.UdtLocationdLongitude);

            runMain.PrintOutput(PrintSunVector.X, PrintSunVector.Y, PrintSunVector.Z);

            Console.Read();
        }
    }
}
