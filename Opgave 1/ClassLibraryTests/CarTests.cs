using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            Car testcar = new Car(1, "Hyundai i20", 17500, "MINBIL1");
            Assert.AreEqual(testcar.Id,1);
            Assert.AreEqual(testcar.Model, "Hyundai i20");
            Assert.AreEqual(testcar.Price, 17500);
            Assert.AreEqual(testcar.LicensePlate, "MINBIL1");
        }
        [TestMethod()]
        public void IdTest()
        {
            Car testcar = new Car(1, "Hyundai i20", 17500, "MINBIL1");
            testcar.Id = 2;
            Assert.AreEqual(testcar.Id, 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.Id = 0);
        }
        [TestMethod()]
        public void ModelTest()
        {
            Car testcar = new Car(1, "Hyundai i20", 17500, "MINBIL1");
            testcar.Model = "Hyundai i30";
            Assert.AreEqual(testcar.Model, "Hyundai i30");
            testcar.Model = "Hyun";
            Assert.AreEqual(testcar.Model, "Hyun");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.Model = "Hyu");
        }
        [TestMethod()]
        public void PriceTest()
        {
            Car testcar = new Car(1, "Hyundai i20", 17500, "MINBIL1");
            testcar.Price = 176000;
            Assert.AreEqual(testcar.Price, 176000);
            testcar.Price = 1;
            Assert.AreEqual(testcar.Price, 1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.Price = -100);
        }
        [TestMethod()]
        public void LicenseplateTest()
        {
            Car testcar = new Car(1, "Hyundai i20", 17500, "MINBIL1");
            testcar.LicensePlate = "MINBIL2";
            Assert.AreEqual(testcar.LicensePlate, "MINBIL2");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.LicensePlate = "MINBIL123");
            testcar.LicensePlate = "MI";
            Assert.AreEqual(testcar.LicensePlate, "MI");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.LicensePlate = "M");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testcar.LicensePlate = "");
            Assert.ThrowsException<ArgumentNullException>(() => testcar.LicensePlate = null);


        }
    }
}