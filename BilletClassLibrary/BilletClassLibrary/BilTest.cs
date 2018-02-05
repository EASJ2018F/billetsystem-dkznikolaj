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
            

            //Assert
            Assert.AreEqual("MC", mc.Køretøj());
        }

        [TestMethod]
        public void BilletPris()
        {
            //Arrange
            var billet = new Billet();

            //Act
            

            //Assert
            Assert.AreEqual(120, billet.PrisUdenRabat);
        }

        [TestMethod]
        public void BilletPrisMedBrobizz()
        {
            //Arrange
            var billet = new Billet {Brobizz = true};

            //Act
            

            //Assert
            Assert.AreEqual(114, billet.PrisMedKunBrobizzRabat);
        }

        [TestMethod]
        public void BilletPrisWeekend()
        {
            //Arrange
            var billet = new Billet();

            //Act
            

            //Assert
            Assert.AreEqual(96, billet.Pris);
        }

        [TestMethod]
        public void BilletPrisMedBrobizzWeekend()
        {
            //Arrange
            var billet = new Billet {Brobizz = true};

            //Act
            

            //Assert
            Assert.AreEqual(91.2, billet.Pris);
        }
    }
}