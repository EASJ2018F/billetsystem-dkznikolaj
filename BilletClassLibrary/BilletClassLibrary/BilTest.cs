using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletClassLibrary;


namespace BilletTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilPris()
        {
            //Arrange
            var bil = new Bil();

            //Act
            int pris = bil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void BilKøretøj()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string pris = bil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", bil.Køretøj());
        }

        [TestMethod]
        public void McPris()
        {
            //Arrange
            var mc = new MC();

            //Act
            int pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void McKøretøj()
        {
            //Arrange
            var mc = new MC();

            //Act
            string køretøj = mc.Køretøj();

            //Assert
            Assert.AreEqual("MC", mc.Køretøj());
        }

        [TestMethod]
        public void BilletPris()
        {
            //Arrange
            var billet = new Billet();

            //Act
            double pris = billet.Pris;

            //Assert
            Assert.AreEqual(120, billet.Pris);
        }

        [TestMethod]
        public void BilletPrisMedBrobizz()
        {
            //Arrange
            var billet = new Billet();
            billet.brobizz = true;

            //Act
            double pris = billet.Pris;

            //Assert
            Assert.AreNotEqual(120, billet.Pris);
        }
    }
}
