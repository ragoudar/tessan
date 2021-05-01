using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_tessan;

namespace test_tessanTests
{
     [TestClass]
    public class CombinationTest
    {
         [TestMethod]
         public void Should_GetCorrectCountPossibilities()
         {
            Combination cmb = new Combination(3, 1, 2);
            var totalPossibilities = cmb.CountPossibilities();

            Assert.AreEqual(3, totalPossibilities);
            
         }
    }

}