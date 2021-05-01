using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_tessan;

namespace test_tessanTests
{
    [TestClass]
    public class AdditionToGetNTest
    {
        [TestMethod]
        public void Should_Obtain8ByAddingTwoDistincElement()
        {
            int[] values = new[] {1, 1, 2, 3, 5};          
            AdditionToGetN additionToGetN = new AdditionToGetN(values, 8);
            var result = additionToGetN.CanObtainTarge();            

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_NOT_Obtain8ByAddingTwoDistincElement()
        {
            int[] values = new[] {1, 1, 2, 3};          
            AdditionToGetN additionToGetN = new AdditionToGetN(values, 8);
            var result = additionToGetN.CanObtainTarge();            

            Assert.IsFalse(result);
        }
    }
}

//dotnet test .\test-tessanTests\test-tessanTests.csproj
