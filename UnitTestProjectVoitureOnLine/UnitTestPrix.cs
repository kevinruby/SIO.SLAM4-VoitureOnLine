using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryVoitureOnLine;

namespace UnitTestProjectVoitureOnLine
{
    [TestClass]
    public class UnitTestPrix
    {
        [TestMethod]
        public void TestPrixVoiture()
        {
            Citadine uneC = new Citadine("Young", "Urban", "Métallisée", "Hybride", false);
            Citadine uneC2 = new Citadine("Young", "Urban", "Métallisée", "Essence", true);
            Citadine uneC3 = new Citadine("Young", "Urban", "Métallisée", "Gasoil", false);
            Compacte uneCo1 = new Compacte("Young", "Urban", "Métallisée", "Essence", true);
            Compacte uneCo2 = new Compacte("Young", "Urban", "Métallisée", "Essence", false);
            Familiale uneF = new Familiale("Young", "Urban", "Métallisée", "Gasoil");
            Limousine uneL = new Limousine("Young", "Urban", "Métallisée", "Hybride");
            Assert.AreEqual(13000, uneC.Prix());
            Assert.AreEqual(10000, uneC2.Prix());
            Assert.AreEqual(10000, uneC3.Prix());
            Assert.AreEqual(20000, uneCo1.Prix());
            Assert.AreEqual(17000, uneCo2.Prix());
            Assert.AreEqual(25000, uneF.Prix());
            Assert.AreEqual(35000, uneL.Prix());
        }
    }
}
