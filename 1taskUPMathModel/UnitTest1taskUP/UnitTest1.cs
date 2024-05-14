using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using _1taskUPMathModel;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest1taskUP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            double rozhd = 0.0145;
            double smr = 0.0016;
            double pervGod = 4635200;
            double[] expected = { 4635200, 4694994, 4755560, 4816906, 4879044, 4941984, 5005736, 5070310, 5135717, 5201967, 5269073 };
            double[] actual = new double[11];
            //act and assert
            double[]temp=CalcPopulation.Calc(rozhd,smr,pervGod);
            for(int i = 0;i < actual.Length; i++) {
                actual[i] = temp[i];
            }
            Assert.IsTrue(expected.SequenceEqual(actual));

        }
    }
}
