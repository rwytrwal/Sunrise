using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sunrise.Calculate;

namespace Sunrise.Test
{
    [TestClass]
    public class SunriseComputeTest
    {
        [TestMethod]
        public void ShouldEqualSunPossReturn()
        {
            ComputeVector sut = new ComputeVector();
            DateTime data = new DateTime(2003, 1, 1, 1, 12, 0);
            SunVector vector = sut.SunPos(data, 0, 0);

            decimal expectedX = 145.2014M;
            decimal expectedY = 151.526M;
            decimal expectedZ = -61.526M;

            Assert.AreEqual(expectedX, vector.AzimutDecimal);
            Assert.AreEqual(expectedY, vector.ZenithDecimal);
            Assert.AreEqual(expectedZ, vector.ElevationDecimal);
            
        }

        [TestMethod]
        public void ShouldEqualSunPossReturnCenterValue()
        {
            ComputeVector sut = new ComputeVector();
            DateTime data = new DateTime(2003, 6, 1, 1, 12, 0);
            SunVector vector = sut.SunPos(data, 0, 0);

            decimal expectedX = 38.2979M;
            decimal expectedY = 151.5241M;
            decimal expectedZ = -61.5241M;

            Assert.AreEqual(expectedX, vector.AzimutDecimal);
            Assert.AreEqual(expectedY, vector.ZenithDecimal);
            Assert.AreEqual(expectedZ, vector.ElevationDecimal);

        }


        [TestMethod]
        public void ShouldEqualSunPossReturnBoundaryValue()
        {
            ComputeVector sut = new ComputeVector();
            DateTime data = new DateTime(2003, 12, 30, 1, 12, 0);
            SunVector vector = sut.SunPos(data, 0, 0);

            decimal expectedX = 144.9989M;
            decimal expectedY = 151.2497M;
            decimal expectedZ = -61.2497M;

            Assert.AreEqual(expectedX, vector.AzimutDecimal);
            Assert.AreEqual(expectedY, vector.ZenithDecimal);
            Assert.AreEqual(expectedZ, vector.ElevationDecimal);

        }



    }
}
